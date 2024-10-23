using System;
using System.Collections.Generic;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read and Populate Input
            // Perform Logic
            int size = 0;
            Battleship bs;
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                size = Convert.ToInt32(reader.ReadLine());
                bs = new Battleship(size);

                int totalShips = Convert.ToInt32(reader.ReadLine());
                var p1 = reader.ReadLine().Split(':').ToList();
                foreach(var x in p1){
                    var temp = x.Split(',');
                    bs.arr1[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])] = 'B';
                }

                var p2 = reader.ReadLine().Split(':').ToList();
                foreach(var x in p2){
                    var temp = x.Split(',');
                    bs.arr2[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])] = 'B';
                }

                var missileCount = Convert.ToInt32(reader.ReadLine());

                var m1 = reader.ReadLine().Split(':').ToList();
                foreach(var x in m1){
                    var temp = x.Split(',');
                    bs.arr2[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])] 
                        = bs.arr2[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])]=='B' ? 'X' : 'O';
                }

                var m2 = reader.ReadLine().Split(':').ToList();
                foreach(var x in m2){
                    var temp = x.Split(',');
                    bs.arr1[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])] 
                        = bs.arr1[Convert.ToInt32(temp[0]),Convert.ToInt32(temp[1])]=='B' ? 'X' : 'O';
                }
            }

            // Populate output
            // Write output to file
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int countp1 = 0;
                int countp2 = 0;
                writer.WriteLine("Player1");
                for(int i=0; i<size; i++){
                    for(int j=0; j<size; j++){
                        writer.Write(bs.arr1[i,j] + " ");
                        if(bs.arr1[i,j] == 'X'){
                            countp1++;
                        }
                    }
                    writer.WriteLine();
                }

                writer.WriteLine();
                writer.WriteLine("Player2");
                for(int i=0; i<size; i++){
                    for(int j=0; j<size; j++){
                        writer.Write(bs.arr2[i,j] + " ");
                        if(bs.arr2[i,j] == 'X'){
                            countp2++;
                        }
                    }
                    writer.WriteLine();
                }

                writer.WriteLine();
                writer.WriteLine("P1:" + countp1);
                writer.WriteLine("P2:" + countp2);
                writer.WriteLine(countp1==countp2 ? "It is a draw" 
                    : countp1 > countp2 ? "Player 1 wins" : "Player 2 wins");
            }
        }
    }

    public class Battleship{
        public char[,] arr1 {get;set;}
        public char[,] arr2 {get;set;}
        public Battleship(int size){
            this.arr1 = new char[size, size];
            for(int i=0; i<size; i++){
                for(int j=0; j<size; j++){
                    this.arr1[i,j] = '_';
                }
            }

            this.arr2 = new char[size, size];
            for(int i=0; i<size; i++){
                for(int j=0; j<size; j++){
                    this.arr2[i,j] = '_';
                }
            }
        }

        public void TotalShip(){

        }

        public void TotalMissile(){

        }
    }
}