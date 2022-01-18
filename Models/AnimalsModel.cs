using System;

namespace aspapi.Models{

    public class AnimalsModel{
        public int id {get; set;}
        public string name {get; set;}

        public AnimalsModel(int id, string name){
            this.id=id;
            this.name=name;
        }
    }
}