using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forPracticeMatriz
{
    class classMatriz
    {
        // Propiedades 
        const int maxFila = 50;
        const int maxColum = 50;
        private int[,] matriz;
        private int fila, colum;

        // constructor
        public classMatriz()
        {
            matriz = new int[maxFila, maxColum];
            fila = 0; colum = 0;
        }
        // Metodos
        // Cargar randomicamente
        public void cargarRandon(int numFila, int numColum, int min, int max)
        {
            Random rand = new Random();
            this.fila = numFila; this.colum = numColum;
            for(int fil = 1; fil <= this.fila; fil++)
            {
                for(int col = 1; col <= this.colum; col++)
                {
                    matriz[fila, col] = rand.Next(min, max + 1);
                }
            }
        }
        // Descargar los datos cargados
        public string descargar()
        {
            string sep = "";
            for(int fil = 1; fil <= this.fila; fil++)
            {
                for(int col = 1; col <=this.colum; col++)
                {
                    sep = sep + matriz[fil, col] + "\t";
                }
                sep = sep + "\x000d" + "\x000a";
            }
            return sep;
        }

        // Tipos de series:
        // Cargar una serie de matrices (fila de arriba hacia abajo)
        public void cargarSerie1(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int fil = 1; fil <= this.fila; fil++)
            {
                for(int col = 1; col <= this.colum; col++)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }
        // cargar serie de matrices (fila de abajo hacia arriba)
        public void cargarSerie2(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int fil = this.fila; fil >= 1; fil--)
            {
                for(int col = 1; col <= this.colum; col++)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }

        // cargar serie de matrices (columna de abajo a la izquierda hacia arriba)
        public void cargarSerie3(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int col = 1; col <= this.colum; col++)
            {
                for(int fil = this.fila; fil >=1; fil--)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }
        
        // cargar serie de matrices (columna de arriba a la izquierda hacia abajo)
        public void cargarSerie4(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int col = 1; col <= this.colum; col++)
            {
                for(int fil = 1; fil <= this.fila; fil++)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }

        // cargar serie de matrices (????)
        public void cargarSerie5(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int col = this.colum; col >= 1; col--)
            {
                for(int fil = 1; fil <= this.fila; fil++)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }

        // cargar serie de matrices (????)
        public void cargarSerie6(int numFila, int numColum, int terIni, int number)
        {
            this.fila = numFila; this.colum = numColum;
            int idx = 0;
            for(int col = this.colum; col >= 1; col--)
            {
                for(int fil = this.fila; fil >= 1; fil--)
                {
                    idx++;
                    matriz[fil, col] = terIni + (idx - 1) * number;
                }
            }
        }
    }
}
