using GameLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


    public class Logic
    {
        private Context Context;
        public List<Library> GetAll()
        {
            using (Context = new Context())
            {
                return Context.Libraries.ToList();
            }
        }
        public Library Get(int id)
        {
            using (Context = new Context())
            {
                return Context.Libraries.Find(id);
            }
        }
        

        public void Add(Library game)
        {
            using (Context = new Context())
            {
                Context.Libraries.Add(game);
                Context.SaveChanges();
            }
        }
        public void Update(Library product)
        {
            using (Context = new Context())
            {

                var item = Context.Libraries.Find(product.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(product);
                    Context.SaveChanges();
                }

            }
        }
        public void Delete(int id)
        {
            using (Context = new Context())
            {
                var product = Context.Libraries.Find(id);
                
                if (product != null)
                {
                    Context.Libraries.Attach(product);
                    Context.Libraries.Remove(product);
                    Context.SaveChanges();
                
            }
            }
        }
    }

