using System;
using System.Collections.Generic;
using Accounting;
using Fortius.Domain;
using Fortius.Structures;

namespace Bakery.Model
{/*
    public class Storage : IAccountingRepository
    {
        private readonly Context _dbContext = new Context();
        
        public bool IsChanged
        {
            get { return _dbContext.ChangeTracker.HasChanges(); }
        }

        public void ApplyChanges()
        {
            _dbContext.SaveChanges();
        }

        public void RejectChanges()
        {
            
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IEntityCollection<T> Collection<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Reference<T>() where T : class
        {
            return _dbContext.Table<T>();
        }

        public ITree<T> ReferenceTree<T>() where T : ITreeNode<T>
        {
            throw new NotImplementedException();
        }

        public IEditableTree<T> Tree<T>() where T : IEditableTreeNode<T>
        {
            throw new NotImplementedException();
        }

        public OperationInfo NewOperation(string category)
        {
            throw new NotImplementedException();
        }

        public OperationInfo NewReverseOperation(OperationInfo baseOperation)
        {
            throw new NotImplementedException();
        }
    }*/
}