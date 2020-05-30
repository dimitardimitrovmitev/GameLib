using GameLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///  The main Logic class
///Contains all Functions/Actions
/// </summary>
public class Logic
    {
        //Get All 
        private Context Context;
        public List<Library> GetAll()
        {
            using (Context = new Context())
            {
                return Context.Libraries.ToList();
            }
        }
    //  Get Id
        public Library Get(int id)
        {
            using (Context = new Context())
            {
                return Context.Libraries.Find(id);
            }
        }
        
    //  Add Game
        public void Add(Library game)
        {
            using (Context = new Context())
            {
                Context.Libraries.Add(game);
                Context.SaveChanges();
            }
        }
    // Update Database
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
    //  Delete Game by Id
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

