using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeaTimeDemo.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// 取得單一筆符合條件運算式的資料
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> filter);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);
        /// <summary>
        /// 刪除大量資料
        /// </summary>
        /// <param name="entity"></param>
        void RemoveRange(IEnumerable<T> entity);
    }
}
