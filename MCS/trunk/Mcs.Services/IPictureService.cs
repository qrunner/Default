using System.Drawing;

namespace Mcs.Services
{
    public interface IPictureService
    {
        /// <summary>
        /// Возвращает URI изображения в оригинальном размере
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <returns>URI изображения</returns>
        string GetImagePath(string prefix, int id);

        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер с обрезкой
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>URI изображения</returns>
        string GetImagePath(string prefix, int id, int width, int height);

        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по длинной стороне
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <param name="size">Размер по длинной стороне</param>
        /// <returns>URI изображения</returns>
        string GetImagePathFit(string prefix, int id, int size);

        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по высоте
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <param name="height">Высота</param>
        /// <returns>URI изображения</returns>
        //string GetImagePathFitHeight(string prefix, int id, int height);
        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по ширине
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <param name="width">Ширина</param>
        /// <returns>URI изображения</returns>
        string GetImagePathFitWidth(string prefix, int id, int width);

        /// <summary>
        /// Сохраняет изображение
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        /// <param name="picture">Изображение</param>
        void SetPicture(string prefix, int id, Image picture);

        /// <summary>
        /// Удаляет изображение
        /// </summary>
        /// <param name="prefix">Префикс</param>
        /// <param name="id">Идентификатор</param>
        void DeletePicture(string prefix, int id);
    }
}

/*
 •	XXxYY – длина х ширина
•	original – оригинальный размер
•	fitXX – вписать по ширине и высоте в ХХ
•	widthXX – ширина ХХ, высота – пропорционально
•	heigthYY – высота YY, ширина – пропорционально

 
 */