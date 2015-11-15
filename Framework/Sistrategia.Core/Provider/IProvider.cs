/*********************************************************************************
 * Sistrategia.Provider.IProvider.cs
 * 
 * Author(s):   José Ernesto Ocampo Cicero <ernesto@sistrategia.com>
 * Last Update:	2012-Nov-12
 * Created:	    2008-Dec-03
 * 
 * You can contact Sistrategia (R) / JEOCSI S.A. de C.V. headquarters at
 * mailto:contact@sistrategia.com
 * http://www.sistrategia.com
 * 
 * Copyright (c) 2008-2015 José Ernesto Ocampo Cicero, JEOCSI S.A. de C.V.
 * All rights reserved. 
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use
 * these files except in compliance with the License. You may obtain a copy of the
 * License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed
 * under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 ********************************************************************************/
using System;
using System.Collections.Generic;

namespace Sistrategia.Provider
{
    public interface IProvider
    {
        string Name { get; }
        string Description { get; }

    }
}
