using System;
using aspapi.Models;
using System.Collections.Generic;

namespace aspapi.Services{
 public interface IAnimalServices
    {
        void addAnimal(AnimalsModel animalsModel);
        List<AnimalsModel> GetAllAnimals();
    }
}