﻿namespace WebApiClientCore
{
    /// <summary>
    /// 定义IActionInvoker提供者的接口
    /// </summary>
    public interface IActionInvokerProvider
    {
        /// <summary>
        /// 创建Action执行器
        /// </summary>
        /// <param name="apiAction">Action描述</param>
        /// <returns></returns>
        IActionInvoker CreateActionInvoker(ApiActionDescriptor apiAction);
    }
}