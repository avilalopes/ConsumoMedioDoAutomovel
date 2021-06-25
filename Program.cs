using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Informe a distância percorrida: ");
            distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de combustível gasto: ");            
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia/combustivelGasto; //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio);

    }

}
