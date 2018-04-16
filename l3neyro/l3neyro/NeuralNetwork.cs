using System;
using System.Collections.Generic;
using System.Linq;

namespace l3neyro
{
    class NeuralNetwork
    {
        public double GetY( List<Function> functionList, Function function, double sigma)
        {
            List<double> rList = GetR(functionList, function);
            List<double> dlist = GetD(rList, sigma);
            return GetSumDY(dlist, functionList) / dlist.Sum();
        }

        private List<double> GetR (List<Function> functionList, Function function)
        {
            var rList = new List<double>();

            foreach (var item in functionList)
            {
                double r = Math.Sqrt(Math.Pow((item.X1 - function.X1), 2) + Math.Pow((item.X2 - function.X2), 2));
                rList.Add(r);
            }
            return rList;
        }

        private List<double> GetD(List<double> list, double sigma)
        {
            var dList = new List<double>();

            foreach (var item in list)
            {
                double d = Math.Exp(-Math.Pow(item, 2) / Math.Pow(sigma, 2));
                dList.Add(d);
            }

            return dList;
        }

        private double GetSumDY (List<double> dlist, List<Function> functionList)
        {
            double sumDY = 0;
            for (int i = 0; i < dlist.Count; i++)
            {
                sumDY += dlist[i] * functionList[i].GetResult();
            }
            return sumDY;
        }

       

    }
}
