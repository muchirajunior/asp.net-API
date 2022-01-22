using System;
using System.Collections.Generic;
using aspapi.Models;

namespace aspapi.Services{
   
    public class AnimalServices : IAnimalServices
    {
        public List<AnimalsModel> Animals = new List<AnimalsModel>();
        public void addAnimal(AnimalsModel animalsModel)
        {
            animalsModel.id=Animals.Count+1;
            Animals.Add(animalsModel);
        }

        public List<AnimalsModel> GetAllAnimals()
        {
            return Animals;
        }

    }
}