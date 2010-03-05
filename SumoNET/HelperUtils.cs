using System;
using System.Collections;
using com.articulate.sigma;

namespace SumoNET
{
    public static class HelperUtils
    {
        public static ArrayList ToArrayList(java.util.ArrayList jalist)
        {
            if(jalist == null) return null;
            ArrayList alist = new ArrayList();
            java.util.Iterator it = jalist.iterator();
            while(it.hasNext())
            {
                alist.Add(it.next());
            }
            return alist;
        }

        public static Hashtable ToHashtable(java.util.Map map)
        {
            if(map == null) return null;
            Hashtable table = new Hashtable();
            java.util.Iterator it = map.keySet().iterator();
            while(it.hasNext())
            {
                string key = (string)it.next();
                object val = map.get(key);
                table[key] = val;
            }
            return table;
        }
    }
}