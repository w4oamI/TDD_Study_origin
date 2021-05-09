﻿using System;
//분산 통계량 계산
//조건:  샘플 데이터 : 1 2 3 4 5 6
//--------------------------------------------------------------//
namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inline tempoary variable
            //int n = args.Length;

            if (args.Length == 0)
            {
                Console.WriteLine("데이터가 입력되지 않았습니다.");
                return;
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("두개 이상의 데이터를 입력하세요.");
                return;
            }


            //문자열 데이터를 숫자 데이터로 변환하는 코드 추출
            //-------------------------------------------------------//
            /* 기존 코드
            double [] source = new double[n];
            for(int i=0; i<n;i++){
                source[i] = double.Parse(args[i]);
            }*/


            //위 코드(25~28줄)의 메소드 추출
            double[] source = ParseArguments(args, args.Length);
            //-------------------------------------------------------//


            //평균을 계산하는 코드 추출
            //-------------------------------------------------------//
            //기존 코드
            /*double sum = 0.0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += source[i];
            }

            double mean = sum / args.Length;*/


            //위 코드(42~48줄)의 메소드 추출
            double mean = CalculateMean(args, source);
            //-------------------------------------------------------//



            //sumOfSquares을 계산하는 코드 추출
            //-------------------------------------------------------//
            //기존 코드
            /*double sumOfSquares = 0.0;
            for (int i = 0; i < args.Length; i++)
            {
                sumOfSquares += (source[i] - mean) * (source[i] - mean);
            }*/

            //위 코드(61~65줄)의 메소드 추출
            double sumOfSquares = CalculateSumOfSquares(source, mean);
            //-------------------------------------------------------//

            double variance = sumOfSquares / (args.Length - 1);

            Console.WriteLine($"분산 : {variance}");
        }

        //계산식은 추출된 메소드로 이동되었고, main은 간단해졌다.
        private static double CalculateSumOfSquares(double[] source, double mean)
        {
            double sumOfSquares = 0.0;
            for (int i = 0; i < source.Length; i++)
            {
                sumOfSquares += (source[i] - mean) * (source[i] - mean);
            }

            return sumOfSquares;
        }

        private static double CalculateMean(string[] args, double[] source)
        {
            double sum = 0.0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += source[i];
            }

            double mean = sum / args.Length;
            return mean;
        }

        private static double[] ParseArguments(string[] args, int n)
        {
            double[] source = new double[n];
            for (int i = 0; i < n; i++)
            {
                source[i] = double.Parse(args[i]);
            }

            return source;
        }
    }
}
//--------------------------------------------------------------//
//실행은 .net을 써야 하므로 터미널에서 
//dotnet run 1 2 3 4 5 6  <<<<<<입력.
