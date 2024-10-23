namespace Backend1.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona=new List<PersonaDatos> { 
        new PersonaDatos(){
        Id= 1,
        Name="Wendy Daniela Ayala",
        Age = new DateTime(2004,09,30)
        },
        new PersonaDatos(){
        Id= 2,
        Name="Alejandro Ayala",
        Age = new DateTime(2004,03,03) },

         new PersonaDatos(){
        Id= 3,
        Name="Wendy Ayala",
        Age = new DateTime(2004,09,30) },

        };
    }
}
public class PersonaDatos
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Age { get; set; }
}
