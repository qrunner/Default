using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Accounting;

namespace Bakery.Model
{
    /// <summary>
    /// Тип документа
    /// </summary>
    public class DocumentType : NamedEntity
    {
        public DocumentType()
        {
            Sites = new List<AccountingSite>();
        }

        /// <summary>
        /// Тип операции
        /// </summary>
        [DisplayName("Тип операции")]
        public OperationType Operation { get; set; }

        /// <summary>
        /// Имеется ли контрагент
        /// </summary>
        [DisplayName("Имеется контрагент")]
        public bool HasContractor { get; set; }

        /// <summary>
        /// Участки учета, где применим данный документ
        /// </summary>
        [DisplayName("Участки учета")]
        public virtual ICollection<AccountingSite> Sites { get; protected set; }

        /*public string SiteIds
        {
            get { return Sites.Aggregate("", (acc, site) => string.Format("{0}{1}, ", acc, site.Name)); }
            set
            {
                var names = value.Split(new[] { ',' });
                using (var ctx = new Context())
                {
                    Sites.Clear();
                    foreach (var site in ctx.Sites.Where(x => names.Contains(x.Name)))
                        Sites.Add(site);
                }
            }
        }*/
    }
}