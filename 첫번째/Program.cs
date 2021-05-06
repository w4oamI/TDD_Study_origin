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
            if(args.Length==0){
                Console.WriteLine("데이터가 입력되지 않았습니다.");
                return;
            }
            else if(args.Length == 1){
                Console.WriteLine("두개 이상의 데이터를 입력하세요.");
                return;
            }

            double [] s = new double[args.Length];
            for(int i=0; i<s.Length;i++){
                s[i] = double.Parse(args[i]);
            }

            double sum=0.0;
            for(int i=0;i<s.Length;i++){
                sum += s[i];
            }

            double mean = sum/s.Length;

            double sumOfSquares = 0.0;
            for(int i=0;i<s.Length;i++){
                sumOfSquares += (s[i]-mean) * (s[i]-mean);
            }

            double variance = sumOfSquares / (s.Length -1);

            Console.WriteLine($"분산 : {variance}");
        }
    }
}
//--------------------------------------------------------------//
//실행은 .net을 써야 하므로 터미널에서 
//dotnet run 1 2 3 4 5 6  <<<<<<입력.
