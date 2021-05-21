using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio2
    {
        /// <summary>
        /// ORDENE EM ORDEM CRESCENTE E RETORNE A VARIAVEL CODIGOS
        /// </summary>
        /// <param name="codigos"></param>
        /// <returns></returns>
        
        
        internal List<int> GetCodigosOrdenados(List<int> codigos)
        {
            var codigos_1 = new List<int>();
          
            var cods = codigos.OrderBy(c => c);
            
            foreach (var c in cods)
	        {
                codigos_1.Add(c);
	        }
            return codigos_1;
        }
       


    }
}
