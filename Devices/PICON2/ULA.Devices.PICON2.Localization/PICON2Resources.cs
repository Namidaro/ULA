﻿

using System;


namespace ULA.Devices.PICON2.Localization
{
	/// <summary>
    ///   Represents an application resources accessor functionality
    /// </summary>
    public class PICON2Resources
    {
		private static readonly Lazy<PICON2Resources> _factory =
            new Lazy<PICON2Resources>(() => new PICON2Resources());

        /// <summary>
        ///     Gets current instance of <see cref="PICON2Resources" />
        /// </summary>
        public static PICON2Resources Instance
        {
            get { return PICON2Resources._factory.Value; }
        }


		private static System.Resources.ResourceManager _resourceMan;

		/// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
		internal static System.Resources.ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(_resourceMan, null)) 
				{
                    var temp = new System.Resources.ResourceManager("ULA.Devices.PICON2.Localization.Properties.Resources", typeof(PICON2Resources).Assembly);
                    _resourceMan = temp;
                }
                return _resourceMan;
            }
        }
			

	    /// <summary>
        /// Gets a resource by its name
        /// </summary>
        /// <param name="resource">The name of the resource to obtain</param>
        /// <returns>An instance of the obtained resource</returns>
		public string this[string resource]
		{
			get
			{
				return string.IsNullOrWhiteSpace(resource)
                          ? string.Empty
                          : ResourceManager.GetString(resource, null);
			}
		}



		/// <summary>
        ///   Looks up a localized string similar to Ассоциируемый драйвер с текущим устройством не найден
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string NoAssociatedDriverExceptionMessage 
		{
			get 
			{
				return ResourceManager.GetString("NoAssociatedDriverExceptionMessage", null);
			}
		}
		/// <summary>
        ///   Looks up a localized string similar to Драйвер таблицы данных
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string DriverDataTable 
		{
			get 
			{
				return ResourceManager.GetString("DriverDataTable", null);
			}
		}
		/// <summary>
        ///   Looks up a localized string similar to Сохраненный слой не может получить доступ к драйверу с  ID:
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string NotAccessFromPersistableToDriver 
		{
			get 
			{
				return ResourceManager.GetString("NotAccessFromPersistableToDriver", null);
			}
		}
		/// <summary>
        ///   Looks up a localized string similar to Невозможно восстановить состояние драйвера с идентификатором:
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string NotRestoreStateOfDriver 
		{
			get 
			{
				return ResourceManager.GetString("NotRestoreStateOfDriver", null);
			}
		}
		/// <summary>
        ///   Looks up a localized string similar to Нет возможности работать с драйвером типа: 
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string NotWorkWithDriverType 
		{
			get 
			{
				return ResourceManager.GetString("NotWorkWithDriverType", null);
			}
		}
		/// <summary>
        ///   Looks up a localized string similar to Драйвер с идентификатором {0} не имеет таблицы данных для настройки
        /// </summary>
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
	    public string DriverNotHaveDataTableSetup 
		{
			get 
			{
				return ResourceManager.GetString("DriverNotHaveDataTableSetup", null);
			}
		}

       
    }
}
