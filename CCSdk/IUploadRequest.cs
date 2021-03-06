﻿using System.Collections.Generic;
using System.IO;
using CCSdk.Util;


namespace CCSdk
{
  /// <summary>
  /// 上传文件请求接口，支持同时上传多个文件
  /// </summary>
  public interface IUploadRequest : IRequest
  {
    /// <summary>
    /// 设置或获取上传的文件列表
    /// </summary>
    string[] Files { set; get; }
  }

  internal interface IUploadRequest<T> : IUploadRequest, IRequest<T> where T : ResponseBase
  {
    IDictionary<string, FileItem> GetFileParameters();
  }
}
