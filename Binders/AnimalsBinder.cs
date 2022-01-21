using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace aspapi.Binders{

    class AnimalsBinder : IModelBinder{

        public Task BindModelAsync(ModelBindingContext bindingContext){
            var data = bindingContext.HttpContext.Request.Query;
            var result = data.TryGetValue("animals", out var animals);

            if (result){
                var array= animals.ToString().Split("|");

                bindingContext.Result= ModelBindingResult.Success(array);
            }

            return Task.CompletedTask;
        }

    }
}