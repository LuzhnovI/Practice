using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Point
    {
        public Point(int x, int y, string name)
        {
            x_ = x;
            y_ = y;
            name_ = name;
        }
        private int x_;
        private int y_;
        private string name_;

        public int GetX { get { return x_; } }
        public int GetY { get { return y_; } }
        public string GetName { get { return name_; } }

    }
    class Figure
    {
        public Figure(Point a, Point b, Point c)
        {
            a_ = a;
            b_ = b;
            c_ = c; 

        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            a_ = a;
            b_ = b;
            c_ = c;
            d_ = d; 
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            a_ = a;
            b_ = b;
            c_ = c;
            d_ = d;
            e_ = e;
        }
        private Point a_, b_, c_, d_, e_;
        private double 
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.GetX-A.GetX)* (B.GetX - A.GetX)+ (B.GetY - A.GetY) * (B.GetY - A.GetY));
        }
        void PerimeterCalculator(),
    }
}
