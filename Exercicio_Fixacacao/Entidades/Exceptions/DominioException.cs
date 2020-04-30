using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacacao.Entidades.Exceptions {
    class DominioException : ApplicationException {

        public DominioException(string message): base(message) {

        }
    }
}
