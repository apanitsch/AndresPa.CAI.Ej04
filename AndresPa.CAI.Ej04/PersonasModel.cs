using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresPa.CAI.Ej04;
internal class PersonasModel
{
    public List<Persona> Personas = new List<Persona>()
    {
        new Persona { Documento = 56778462, Apellido="Perez",       Nombre="Juan",  Telefono="31798877" },
        new Persona { Documento = 33124572, Apellido="Lopez",       Nombre="Carla", Telefono="44714478" },
        new Persona { Documento = 22214574, Apellido="Carlomagno",  Nombre="Anahí", Telefono="3647489" },
        new Persona { Documento = 67974578, Apellido="Messi",       Nombre="Leo",   Telefono="444784654" },
        new Persona { Documento = 31112457, Apellido="Martinez",    Nombre="Dibu",  Telefono="313212444" },
    };

    internal string Borrar(Persona persona)
    {
        if (persona.Documento == 31112457)
        {
            return "No puede borrar a esta persona.";
        }

        Personas.Remove(persona);
        return null;
    }

    internal string Modificar(Persona personaAModificar, Persona personaNuevaVersion)
    {
        /*Tooooodas las validaciones imaginables*/
        if (personaNuevaVersion.Documento < 0 || personaNuevaVersion.Documento > 99_999_999)
        {
            return "El documento debe ser un numero entre 1 y 99.999.999";
        }

        if (string.IsNullOrWhiteSpace(personaNuevaVersion.Apellido))
        {
            return "Debe ingresar un apellido.";
        }

        if (personaNuevaVersion.Apellido.Length > 50)
        {
            return "El apellido debe tener menos de 50 caracteres.";
        }

        //yada yada yada......
        //si está todo bien hacemos la modificacion.
        personaAModificar.Documento = personaNuevaVersion.Documento;
        personaAModificar.Apellido = personaNuevaVersion.Apellido;
        personaAModificar.Nombre = personaNuevaVersion.Nombre;
        personaAModificar.Telefono = personaNuevaVersion.Telefono;
        return null;
    }
}
