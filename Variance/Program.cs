using System;
//분산 통계량 계산
//조건:  샘플 데이터 : 1 2 3 4 5 6
//--------------------------------------------------------------//
namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = args.Length;
            if(n == 0){
                Console.WriteLine("데이터가 입력되지 않았습니다.");
                return;
            }
            else if(n == 1){
                Console.WriteLine("두개 이상의 데이터를 입력하세요.");
                return;
            }

            double [] source = new double[n];
            for(int i=0; i<n;i++){
                source[i] = double.Parse(args[i]);
            }

            double sum=0.0;
            for(int i=0;i<n;i++){
                sum += source[i];
            }

            double mean = sum/n;

            double sumOfSquares = 0.0;
            for(int i=0;i<n;i++){
                sumOfSquares += (source[i]-mean) * (source[i]-mean);
            }

            double variance = sumOfSquares / (n -1);

            Console.WriteLine($"분산 : {variance}");
        }
    }
}
//--------------------------------------------------------------//
//실행은 .net을 써야 하므로 터미널에서 
//dotnet run 1 2 3 4 5 6  <<<<<<입력.
