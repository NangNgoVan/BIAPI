public class ResultModel {
    public bool IsError {get;set;}
    public string Message {get;set;}
    public object Data {get;set;}

    public ResultModel(bool err = false, string msg = "", object data = null)
    {
        IsError = err;
        Message = msg;
        Data = data;
    }
}