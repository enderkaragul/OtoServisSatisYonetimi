using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OtoServisSatis.BL.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> expression); //Gelen parametreye göre dinamik bir sorgulama yappıp ilgili kaydın ilgili klasın
                                                              //listesini sorgulayarak filtreyelerek dönüş yapacağız
                                                              //Buradaki amaç SQL de sorgulamanın karşılığu burada expression

        IQueryable<T> GetAllByInclude(string table); 

        T Find(int id); //ID ye göre bulma

        T Get(Expression<Func<T, bool>> expression); //gelen sorguya göre sadece ID ye göre değil diğer alanlara göre de sorgulama yapabilsin

        //CRUD Metodları
        int Add(T entity);

        int Update(T entity);

        int Delete(int id);

    }
}
