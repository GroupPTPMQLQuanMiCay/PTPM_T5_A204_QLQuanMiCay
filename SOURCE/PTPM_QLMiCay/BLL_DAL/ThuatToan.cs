using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Math.Random;
using Accord.Statistics.Kernels;
using Accord;
using Accord.Math;
using BLL_DAL;

namespace BLL_DAL
{
    public class ThuatToan
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        DAL_Mon _monBLL = new DAL_Mon();
        DAL_Order _orderBLL = new DAL_Order();
        static int NUMBER = 0;

        public ThuatToan()
        {
            NUMBER = _context.Mons.Count();
        }

        private int[] PerformKMeansForOrder(List<string> tenMonOrder)
        {
            double[][] featureVector = GetData();
            KMeans kmeans = new KMeans(k: 5);

            var clusters = kmeans.Learn(featureVector);

            int[] labels = clusters.Decide(convertListData(tenMonOrder));
            return labels;
        }

        private double[][] GetData()
        {
            int numMons = _context.Mons.Count();
            Mon[] mons = _monBLL.LoadAllMon().ToArray();
            int numHoaDons = _context.HoaDons.Count();
            double[][] data = new double[numHoaDons][];

            for (int i = 0; i < numHoaDons; i++)
            {
                data[i] = new double[NUMBER];
                List<string> monHD = _orderBLL.getTenMonTheoHDID(i + 1);
                for (int j = 0; j < NUMBER; j++)
                {
                    if (monHD.Contains(mons[j].M_Ten))
                        data[i][j] = 1;
                    else
                        data[i][j] = 0;
                }
            }

            return data;
        }

        private double[][] convertListData(List<string> tenMonOrder)
        {
            int numMons = tenMonOrder.Count();
            Mon[] mons = _monBLL.LoadAllMon().ToArray();

            double[][] data = new double[1][];

            data[0] = new double[NUMBER];
            for (int j = 0; j < NUMBER; j++)
            {
                if (tenMonOrder.Contains(mons[j].M_Ten))
                    data[0][j] = 1;
                else
                    data[0][j] = 0;
            }

            return data;
        }

        private double[][] convertData(Mon monOrder)
        {
            Mon[] mons = _monBLL.LoadAllMon().ToArray();

            double[][] data = new double[1][];

            data[0] = new double[NUMBER];
            for (int j = 0; j < NUMBER; j++)
            {
                if (monOrder.Equals(mons[j].M_Ten))
                {
                    data[0][j] = 1;
                    break;
                }
            }

            return data;
        }

        private Mon RandomMon(int cluster)
        {
            double[][] featureVector = GetData();
            KMeans kmeans = new KMeans(k: 5);

            var clusters = kmeans.Learn(featureVector);

            Random random = new Random();

            List<Mon> monCluster = new List<Mon>();
            for (int j = 0; j < NUMBER; j++)
            {
                Mon mon = _context.Mons.Skip(j).Take(1).FirstOrDefault(); ;
                if (mon != null)
                {
                    double[][] temp = convertData(mon);
                    int[] labels = clusters.Decide(temp);
                    if (labels[0] == cluster)
                        monCluster.Add(mon);
                }
            }

            if (monCluster.Count == 0)
                return null;

            int index = random.Next(monCluster.Count() - 1);
            return monCluster[index];
        }

        public List<Mon> GetTop5MonGoiY(List<string> tenMonOrder)
        {
            List<Mon> monGoiY = new List<Mon>();
            List<int> clusters = new List<int>();
            int[] clusterOrder = PerformKMeansForOrder(tenMonOrder);

            foreach (int item in clusterOrder)
            {
                if (!clusters.Contains(item) && clusters.Count() < 5)
                    clusters.Add(item);
            }
            int i = 0;
            while (monGoiY.Count() < 5)
            {
                if (i == clusters.Count())
                    i = 0;
                Mon mon = RandomMon(clusters[i]);
                if (mon != null && !monGoiY.Contains(mon))
                {
                    monGoiY.Add(mon);
                }
                i++;
            }
            return monGoiY;
        }


    }
}
