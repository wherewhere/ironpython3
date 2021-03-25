// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Scripting.Runtime;

namespace IronPython.Runtime.Exceptions {
    #region Generated ImportWarningException

    // *** BEGIN GENERATED CODE ***
    // generated by function: gen_one_exception_specialized from: generate_exceptions.py

    [Serializable]
    public class ImportWarningException : WarningException, IPythonAwareException {
        private PythonExceptions.BaseException? _pyExceptionObject;
        private List<DynamicStackFrame>? _frames;
        private TraceBack? _traceback;

        public ImportWarningException() : base() { }
        public ImportWarningException(string msg) : base(msg) { }
        public ImportWarningException(string message, Exception innerException)
            : base(message, innerException) {
        }
#if FEATURE_SERIALIZATION
        protected ImportWarningException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("frames", _frames);
            info.AddValue("traceback", _traceback);
            base.GetObjectData(info, context);
        }
#endif

        PythonExceptions.BaseException? IPythonAwareException.PythonException {
            get {
                if (_pyExceptionObject == null) {
                    var newEx = new PythonExceptions.BaseException(PythonExceptions.ImportWarning);
                    newEx.InitializeFromClr(this);
                    _pyExceptionObject = newEx;
                }
                return _pyExceptionObject;
            }
            set { _pyExceptionObject = value; }
        }

        List<DynamicStackFrame>? IPythonAwareException.Frames {
            get { return _frames; }
            set { _frames = value; }
        }

        TraceBack? IPythonAwareException.TraceBack {
            get { return _traceback; }
            set { _traceback = value; }
        }
    }

    // *** END GENERATED CODE ***

    #endregion
}
