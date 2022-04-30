namespace ProEventos.API.models
{
    public class Evento
    {
        public int EventoID { get;  set; }
        public string Local { get; private set; }
        public string DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtPessoas { get; private set; }
        public int Lote { get; private set; }
        public string ImageURL { get; private set; }

        public Evento(int eventoID, string local , string dataEvento, string tema,int lote, int qtPessoas, string imageURL)
        {
            EventoID = eventoID;
            Local = local;
            DataEvento = dataEvento;
            Tema = tema;
            QtPessoas = qtPessoas;
            Lote = lote;
            ImageURL = imageURL;
        }
    }
}