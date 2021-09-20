using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Locus.Dto.Excecao
{
    [Serializable]
    public class ExcecaoValidacao : Exception
    {
        private readonly Dictionary<string, string> _erros = new Dictionary<string, string>();

        public ExcecaoValidacao(params KeyValuePair<string, string>[] erros)
        {
            foreach (var erro in erros)
            {
                this._erros.Add(erro.Key, erro.Value);
            }
        }

        public Dictionary<string, string> Erros
        {
            get { return this._erros; }
        }

        public string Mensagem
        {
            get
            {
                return string.Join(", ", this._erros.Select(t => string.Format("{0} - {1}", t.Key, t.Value)));
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
