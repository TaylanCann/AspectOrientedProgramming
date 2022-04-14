using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.Aspect
{
    public interface IAspect
    {

    }
    public interface IAfterAspect : IAspect
    {
        object OnAfter(object value);
    }
    public interface IAfterVoidAspect : IAspect
    {
        void OnAfter(object value);
    }
    interface IBeforeAspect : IAspect
    {
        object OnBefore();
    }
    public interface IBeforeVoidAspect : IAspect
    {
        void OnBefore();
    }
    public abstract class AspectBase : Attribute, IAspect
    {

    }
}
