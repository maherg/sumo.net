using System;
using System.Collections;
using com.articulate.sigma;

namespace SumoNET
{
    public class PreferenceCollection
    {
        private KBmanager _mgr;

        #region Constructors
        
        public PreferenceCollection()
        {
            _mgr = KBmanager.getMgr();
        }

        #endregion

        #region Public Properties
        
        public string this[string key]
        {
            get
            {
                return _mgr.getPref(key);
            }
            set
            {
                _mgr.setPref(key, value);
            }
        }

        public string BaseDirectory
        {
            get
            {
                return _mgr.getPref("baseDir");
            }
        }

        public string KnowledgeBaseDirectory
        {
            get
            {
                return _mgr.getPref("kbDir");
            }
        }

        public string Hostname
        {
            get
            {
                return _mgr.getPref("hostname");
            }
        }

        #endregion
    }
}