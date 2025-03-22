using System;
using System.Linq.Expressions;

namespace Dime.Scheduler
{
    public class Sorter<T>
    {
        private bool _isAscending;
        private string _property;

        public Sorter<T> WithProperty<TProperty>(Expression<Func<T, TProperty>> propertyLambda)
        {
            MemberExpression member = (MemberExpression)propertyLambda.Body;
            _property = member.Member.Name;
            return this;
        }

        public Sorter<T> WithAscendingOrder()
        {
            _isAscending = true;
            return this;
        }

        public Sorter<T> WithDescendingOrder()
        {
            _isAscending = false;
            return this;
        }

        private string GetDirection() => _isAscending ? "ASC" : "DESC";

        public override string ToString()
            => $"{{'direction':'{GetDirection()}','property':'{_property}'}}";
    }
}