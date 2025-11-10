using PetCare.Models;

namespace PetCare.Data
{
    public class PetsRepo
    {
        private static readonly List<Mascota> _mascotas = new();

        public static IReadOnlyList<Mascota> GetAllPets() => _mascotas.AsReadOnly();

        public static void AddPet(Mascota m)
        {
            _mascotas.Add(m);
        }
    }
}
