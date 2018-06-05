using System;

namespace ULA.Interceptors.IoC
{
    /// <summary>
    ///     Exposes IoC Container functionality
    ///     ��������� ���������� IoC ����������
    /// </summary>
    public interface IIoCContainer
    {
        /// <summary>
        ///     Resolves a <see cref="Type" /> by the name of the mapping
        /// </summary>
        /// <typeparam name="T"><see cref="Type" /> to resolve</typeparam>
        /// <param name="mappingKey">The name of the mapping to resolve an instance with</param>
        /// <returns>An instance of the retrieved object</returns>
        T Resolve<T>(string mappingKey);

        /// <summary>
        ///     Resolves a <see cref="Type" /> by the name of the mapping
        /// </summary>
        /// <typeparam name="T"><see cref="Type" /> to resolve</typeparam>
        /// <returns>An instance of the retrieved</returns>
        T Resolve<T>();
   


    }
}