using System;
using System.Linq.Expressions;

namespace Dime.Scheduler.Sdk.Samples
{
    public class Filter<T>
    {
        private Operator _oper;
        private object _val;
        private string _property;

        public Filter<T> WithOperator(Operator oper)
        {
            _oper = oper;
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
            => $"{{ 'operator':'{_oper.GetDescription()}','value':{_val},'property':'{_property}'}}";
    }
}