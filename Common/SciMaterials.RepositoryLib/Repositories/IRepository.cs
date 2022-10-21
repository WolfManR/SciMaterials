﻿namespace SciMaterials.RepositoryLib.Repositories;

/// <summary> Интерфейс репозиториев. </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : class
{
    /// <summary> Получить кол-во экземпляров в БД. </summary>
    /// <returns> Кол-во экземпляров. </returns>
    int GetCount();

    /// <summary> Получить кол-во экземпляров в БД. Асинхронный. </summary>
    /// <returns> Кол-во экземпляров. </returns>
    Task<int> GetCountAsync();

    /// <summary> Получить страницу экземпляров. </summary>
    /// <param name="pageNumb"> Номер страницы. </param>
    /// <param name="pageSize"> Размер страницы. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Список экземпляров. </returns>
    List<T>? GetPage(int pageNumb, int pageSize, bool disableTracking = true, bool include = false);

    /// <summary> Получить страницу экземпляров. Асинхронный. </summary>
    /// <param name="pageNumb"> Номер страницы. </param>
    /// <param name="pageSize"> Размер страницы. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Список экземпляров. </returns>
    Task<List<T>?> GetPageAsync(int pageNumb, int pageSize, bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр модели по Id. </summary>
    /// <param name="id"> Id экземпляра модли в БД. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Найденный в БД экземпляр модли или null. </returns>
    T? GetById(Guid id, bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр модели по Id. Асинхронный. </summary>
    /// <param name="id"> Id экземпляра модли в БД. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Найденный в БД экземпляр модли или null. </returns>
    Task<T?> GetByIdAsync(Guid id, bool disableTracking = true, bool include = false);

    /// <summary> Добавить экзепляр модели в БД. </summary>
    /// <param name="entity"> Добавляемый экземпляр. </param>
    void Add(T entity);

    /// <summary> Добавить экзепляр модели в БД. Асинхронный. </summary>
    /// <param name="entity"> Добавляемый экземпляр. </param>
    Task AddAsync(T entity);

    /// <summary> Обновить экземпляр модели. </summary>
    /// <param name="entity"> Экземпляр с новыми данными. </param>
    void Update(T entity);

    /// <summary> Обновить экземпляр модели. Асинхронный. </summary>
    /// <param name="entity"> Экземпляр с новыми данными. </param>
    Task UpdateAsync(T entity);

    /// <summary> Удалить экземпляр модели из БД. </summary>
    /// <param name="entity"> Id удаляемого экземпляра. </param>
    void Delete(T entity);

    /// <summary> Удалить экземпляр модели из БД. Асинхронный. </summary>
    /// <param name="entity"> Id удаляемого экземпляра. </param>
    Task DeleteAsync(T entity);

    /// <summary> Удалить экземпляр модели из БД. </summary>
    /// <param name="id"> Id удаляемого экземпляра. </param>
    void Delete(Guid id);

    /// <summary> Удалить экземпляр модели из БД. Асинхронный. </summary>
    /// <param name="id"> Id удаляемого экземпляра. </param>
    Task DeleteAsync(Guid id);

    /// <summary> Получить список всех экзепляров из БД. </summary>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Список экземпляров. </returns>
    List<T>? GetAll(bool disableTracking = true, bool include = false);

    /// <summary> Получить список всех экзепляров из БД. Асинхронный. </summary>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Список экземпляров. </returns>
    Task<List<T>?> GetAllAsync(bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр по хэш-коду. Асинхронный. </summary>
    /// <param name="hash"> Искомый хэш-код (в текущем методе договорено о строчном варианте хэша). </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Экземпляр класса или null. </returns>
    Task<T?> GetByHashAsync(string hash, bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр по хэш-коду. </summary>
    /// <param name="hash"> Искомый хэш-код (в текущем методе договорено о строчном варианте хэша). </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Экземпляр класса или null. </returns>
    T? GetByHash(string hash, bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр по наименованию. Асинхронный. </summary>
    /// <param name="name"> Искомое наименование. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Экземпляр класса или null. </returns>
    Task<T?> GetByNameAsync(string name, bool disableTracking = true, bool include = false);

    /// <summary> Получить экземпляр по наименованию. </summary>
    /// <param name="name"> Искомое наименование. </param>
    /// <param name="disableTracking"> Отключить отслеживание изменений. </param>
    /// <param name="include"> Подтягивать связанные данные. </param>
    /// <returns> Экземпляр класса или null. </returns>
    T? GetByName(string name, bool disableTracking = true, bool include = false);
}
