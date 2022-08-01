using PerformanceReview;
using Xunit;

namespace PerformanceTesting;

public class PersonaTetsing
{
    [Fact]
    public void ShouldReturnMails()
    {
        //Arrange
        bool bandera = false;
        Persona obj = new Persona();
        List<Persona> personas = new List<Persona>();
        personas.Add(new Persona("Alan", "correo", DateTime.Parse("08/13/1999")));
        personas.Add(new Persona("Pepe", "correo", DateTime.Parse("08/14/1999")));
        personas.Add(new Persona("Migue", "correo", DateTime.Parse("08/15/1999")));
        //Act
        var mailsobtenidos = obj.GetMails(personas);
        foreach (string correo in mailsobtenidos)
        {
            if (correo == "correo")
                bandera = true;
            else bandera = false;
        }
        //Assert
        Assert.True(bandera);
    }
    [Fact]
    public void ShouldReturnABirthdate() {
        //Arrange
        Persona obj = new Persona();
        List<Persona> personas = new List<Persona>();
        personas.Add(new Persona("Jack", "jack@gmail.com", DateTime.Parse("08/14/1999")));
        personas.Add(new Persona("Felipe", "felipe@gmail.com", DateTime.Parse("08/17/1999")));
        personas.Add(new Persona("Juan", "juan@gmail.com", DateTime.Parse("08/18/1999")));
        //Act
        Persona personaRecibida = obj.MayorPrimero(personas);
        //Assert
        Assert.Equal(personaRecibida.BirthDate, DateTime.Parse("08/17/1999"));
    }
}