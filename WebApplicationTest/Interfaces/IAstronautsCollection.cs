using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Interfaces
{
    public interface IAstronautsCollection
    {
        /// <summary>
        /// Получить коллекцию всех астронавтов.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Astronauts> GetAll();

        /// <summary>
        /// Получить информацию об астронавте оп ID
        /// </summary>
        /// <param name="ID">ID Астронавта</param>
        /// <returns></returns>
        Astronauts GetById(int ID);

        /// <summary>
        /// Удалить астронавта по ID
        /// </summary>
        /// <param name="ID">ID Астронавта</param>
        /// <returns></returns>
        bool DeleteByID(int ID);

        /// <summary>
        /// Добавить нового астронавта
        /// </summary>
        /// <param name="NewAstronaut">Новый астронавт</param>
        void AddNewAstronaut(Astronauts NewAstronaut);

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void CommitChanges();
    }
}
