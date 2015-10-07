using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq.Expressions;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    internal static class DbModelBuilderExtensions
    {
        public static void SetUniqueField<T>(this DbModelBuilder modelBuilder, Expression<Func<T, string>> propertyExpression, int? maxLength, string indexName, int indexOrder) where T : Entity
        {
            modelBuilder.Entity<T>().Property(propertyExpression).
                IsRequired().
                HasMaxLength(maxLength).
                HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(indexName, indexOrder)
                {
                    IsUnique = true
                }));
        }

        public static void SetUniqueField<T>(this DbModelBuilder modelBuilder, Expression<Func<T, int>> propertyExpression, string indexName, int indexOrder) where T : Entity
        {
            modelBuilder.Entity<T>().Property(propertyExpression).
                IsRequired().
                HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute(indexName, indexOrder)
                {
                    IsUnique = true
                }));
        }
    }
}