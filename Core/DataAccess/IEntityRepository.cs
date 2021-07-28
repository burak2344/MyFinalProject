using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	//Generic Repository Design Pattern
	//class: referans tip 
	//Buradaki generic yapıda sadece IEntity ve ondan implement edilen classlar T değeri yerinde kullanılır.
	//IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
	//new() : new'lenebilir olmalı.
	public interface IEntityRepository<T> where T:class,IEntity,new()
	{
		//Generic Constraint
		List<T> GetAll(Expression<Func<T,bool>> filter=null);
		T Get(Expression<Func<T, bool>> filter = null);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);

	}
}
