using System;
using System.Linq;
//분산 통계량 계산
//조건:  샘플 데이터 : 1 2 3 4 5 6
//--------------------------------------------------------------//
namespace Variance
{
    class Program
    {
        //static void Main(string[] args)       //71번째줄로 이동
        //{
            //n을 Inline tempoary variable
            //int n = args.Length;




            //if문을 switch문과 입력받는걸로 변환 
            //--------------------------------------------------------------//
            /*
            if (args.Length == 0)
            {
                Console.WriteLine("데이터가 입력되지 않았습니다.");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("두개 이상의 데이터를 입력하세요.");
            }
            else
            {
                //console.WriteLine이 위와 동일 하기 때문에 나머지는 메소드로 변화
                //--------------------------------------------------------------//
                double[] source = ParseArguments(args, args.Length);
                double mean = CalculateMean(args, source);
                double sumOfSquares = CalculateSumOfSquares(source, mean);
                double variance = sumOfSquares / (args.Length - 1);
                string output = $"분산 : {variance}";
                //--------------------------------------------------------------//

                //output을 Inline tempoary variable
                //string output = GetVarianceOutput(args);
                Console.WriteLine(GetVarianceOutput(args));
            }
            */
            //--------------------------------------------------------------//


            //--------------------------------------------------------------//
            //if->switch
            /*
            Console.WriteLine(args.Length switch
            {
                0 => "데이터가 입력되지 않았습니다.",
                1 => "두개 이상의 데이터를 입력하세요.",
                _ => GetVarianceOutput(args)
            });
            */
            //--------------------------------------------------------------//



            //use expression body for methods를 해서 main과 합치기
        static void Main(string[] args) => Console.WriteLine(args.Length switch
            {
                0 => "데이터가 입력되지 않았습니다.",
                1 => "두개 이상의 데이터를 입력하세요.",
                _ => GetVarianceOutput(args)
            });
        



            //문자열 데이터를 숫자 데이터로 변환하는 코드 추출
            //-------------------------------------------------------//
            /* 기존 코드
            double [] source = new double[n];
            for(int i=0; i<n;i++){
                source[i] = double.Parse(args[i]);
            }*/


            //위 코드(25~28줄)의 메소드 추출(else문으로 이동)
            //double[] source = ParseArguments(args, args.Length);
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


            //위 코드(42~48줄)의 메소드 추출(else문으로 이동)
            //double mean = CalculateMean(args, source);
            //-------------------------------------------------------//



            //sumOfSquares을 계산하는 코드 추출
            //-------------------------------------------------------//
            //기존 코드
            /*double sumOfSquares = 0.0;
            for (int i = 0; i < args.Length; i++)
            {
                sumOfSquares += (source[i] - mean) * (source[i] - mean);
            }*/

            //위 코드(61~65줄)의 메소드 추출(else문으로 이동)
            //double sumOfSquares = CalculateSumOfSquares(source, mean);
            //-------------------------------------------------------//


            //(else문으로 이동)
            //double variance = sumOfSquares / (args.Length - 1);
            //Console.WriteLine($"분산 : {variance}");
        //}

        private static string GetVarianceOutput(string[] args)
        {
            double[] source = ParseArguments(args); //ParseArguments에서 매개변수를 하나만 썼기 때문에 args.Length 삭제.
            double mean = CalculateMean(args, source);
            double sumOfSquares = CalculateSumOfSquares(source, mean);
            double variance = sumOfSquares / (args.Length - 1);
            //output을 Inline tempoary variable
            return $"분산 : {variance}";
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

        private static double CalculateMean(string[] args, double[] source) => source.Average();
        //{
            //밑에 코드를 없애기 위해 한줄로 만들었다. 그리고 expressio을 적용
            //return source.Average();
            // double sum = 0.0;
            // for (int i = 0; i < args.Length; i++)
            // {
            //     sum += source[i];
            // }
            // //mean을 인라인
            // //double mean = sum / args.Length;
            // //return mean;
            // return sum / args.Length;
        //}
        //--------------------------------------------------------------//
        // private static double[] ParseArguments(string[] args) //링크를 사용하기 때문에 두번째 파라미터도 안쓴다. (int n)
        // {
        //     //for를 링크로 전환하여 사용하여 파싱하기
        //     //--------------------------------------------------------------//
        //     return args.Select(double.Parse).ToArray();  
            
        //     // double[] source = new double[n];
        //     // for (int i = 0; i < n; i++)
        //     // {
        //     //     source[i] = double.Parse(args[i]);
        //     // }

        //     // return source;
        //     //--------------------------------------------------------------//
        // }

        //해당 블럭을 use expression body for methods
        private static double[] ParseArguments(string[] args) 
        => args.Select(double.Parse).ToArray();
        //--------------------------------------------------------------//
    }
}
//--------------------------------------------------------------//
//실행은 .net을 써야 하므로 터미널에서 
//dotnet run 1 2 3 4 5 6  <<<<<<입력.


//알아야 할것.
//----------------------------------//
//use expression body for methods 단축키 -> 컨트롤+. 누르거나 옆에 노란 전구를 누르면 된다.



//위의 코드의 주석을 제거하면 전보다 코드의 양이 많이 줄었다.
//-----------------------------------------------------------------------------//
namespace Variance
{
    class Program
    {
        static void Main(string[] args) => Console.WriteLine(args.Length switch
            {
                0 => "데이터가 입력되지 않았습니다.",
                1 => "두개 이상의 데이터를 입력하세요.",
                _ => GetVarianceOutput(args)
            });

            private static string GetVarianceOutput(string[] args)
        {
            double[] source = ParseArguments(args);
            double mean = CalculateMean(args, source);
            double sumOfSquares = CalculateSumOfSquares(source, mean);
            double variance = sumOfSquares / (args.Length - 1);

            return $"분산 : {variance}";
        }

        private static double CalculateSumOfSquares(double[] source, double mean)
        {
            double sumOfSquares = 0.0;
            for (int i = 0; i < source.Length; i++)
            {
                sumOfSquares += (source[i] - mean) * (source[i] - mean);
            }

            return sumOfSquares;
        }

        private static double CalculateMean(string[] args, double[] source) => source.Average();
        private static double[] ParseArguments(string[] args) 
        => args.Select(double.Parse).ToArray();
    }
}
//-----------------------------------------------------------------------------//