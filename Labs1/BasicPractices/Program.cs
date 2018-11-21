using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractices
{
    // Hinh vuong don vi canh 0-1
    // Duong tron noi tiep hinh vuong
    // Tinh Pi

    class CountPi
    {
        // Toa do truc hoanh (ngang)
        public double coordinateX;
        // Toa do truc tung (thang dung)
        public double coordinateY;
        // so lan gieo
        public int numberOfTest = 0;
        public int numberDotInCircle = 0;



        ////Constructor
        //public CountPi(double tempX, double tempY)
        //{
        //    coordinateX = tempX;
        //    coordinateY = tempY;
        //}

        // Sinh ngau nhien 1 diem thuoc hinh vuong
        public void GieoDiem()
        {
            //coordinateX = 0.1;
            //coordinateY = 0.1;

            Random random = new Random();
            // Ngau nhien x
            coordinateX = random.NextDouble();
            // Ngau nhien y
            coordinateY = random.NextDouble();
        }

        // Xet xem DIEM do nam trong hinh tron hay ngoai
        public int SuKien()
        {
            // ban kinh cua diem M  -- Hay -- Khoang cach tu M den tam cua duong tron
            double distanceDottoCenter;
            distanceDottoCenter = Math.Sqrt(Math.Pow(coordinateX - 0.5, 2) + Math.Pow(coordinateY - 0.5, 2));

            // Neu trong hinh tron
            if (distanceDottoCenter <= 0.5)
            {
                return 1;
            }
            // Ngoai hinh tron
            else
            {
                return 0;
            }
        }

        // Tong so lan gieo diem
        public void SoLanGieo()
        {
            Console.WriteLine("Tong so lan gieo: {0}", numberOfTest);

        }

        //Tan suat
        public double TanSuat()
        {
            // ti so S1/S
            return 0;
        }

        // Tinh Pi voi xac suat  epsilon
        public double Pi()
        {
            return 0;
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            #region CountPi
            int inputNumber;
            int numberDotInCircle = 0;

            // Nhap so lan gieo
            Console.WriteLine("Nhap so lan gieo: ");
            inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("So lan gieo: {0}", inputNumber);
            Console.WriteLine("*********************************");

            inputNumber = 10;

            for (int i = 0; i < inputNumber; i++)
            {
                CountPi countPiClassObject = new CountPi();
                countPiClassObject.GieoDiem();
                Console.WriteLine("Toa do X: {0}", countPiClassObject.coordinateX);
                Console.WriteLine("Toa do Y: {0}", countPiClassObject.coordinateY);

                if (countPiClassObject.SuKien() == 1)
                {
                    numberDotInCircle++;
                }
            }
            
            Console.WriteLine("So lan gieo trong hinh tron: {0}", numberDotInCircle);
            
            #endregion

            Console.ReadLine();
        }
    }
}
