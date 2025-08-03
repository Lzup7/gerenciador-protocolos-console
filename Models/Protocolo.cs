namespace
GerenciadorProtocolos.Models{
    public class Protocolo{
        public int Id { get; set;}
        public string Numero {get; set;}
        public string Descricao{ get; set;}
        public string Solicitante{ get; set;}
        public DateTime DataEntrada { get; set;}
        public string Status{ get; set;} //Pendente,Encaminhado,Finalizado
    }
}