namespace CoreLayer.DataAccess.Utilitis.Result.DataResult
{
    public class ErrorDataResult<TData>:DataResult<TData>
    {
        public ErrorDataResult(TData data):base(false,data)
        {

        }
        public ErrorDataResult(string message,TData data):base(false,message,data)
        {

        }
    }
}