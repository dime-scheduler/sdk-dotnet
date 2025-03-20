using System;
using System.Linq.Expressions;

namespace Dime.Scheduler
{
    public class Filter<T>
    {
        private Operator _filterOperator;
        private object _val;
        private string _property;

        public Filter<T> WithOperator(Operator filterOperator)
        {
            _filterOperator = filterOperator;
            return this;
        }

        public Filter<T> WithValue<TVal>(TVal val)
        {
            _val = val;
            return this;
        }

        public Filter<T> WithProperty<TProperty>(Expression<Func<T, TProperty>> propertyLambda)
        {
            MemberExpression member = (MemberExpression)propertyLambda.Body;
            _property = member.Member.Name;
            return this;
        }

        public override string ToString()
            => $"{{ 'operator':'{_filterOperator.GetDescription()}','value':{_val},'property':'{_property}'}}";
    }
}