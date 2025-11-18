namespace books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string titulo;
        public string autor;
        public int anio;

          public Book()
        {

        }
          
       
        
        public Book(int p_Id, string p_titulo, string p_autor, int p_anio)
        {
            this.Id = p_Id;
            this.anio = p_anio;
            this.autor = p_autor;
            this.titulo = p_titulo;

        }
    }
}
