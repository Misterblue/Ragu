﻿// Copyright 2018 Robert Adams
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;


// Creates a web socket listener and waits for a Basil browser to connect.
// Once connected, handles transport of datablocks.
namespace org.herbal3d.ragu {
    public class BTransportWS : BTransport {
        public BTransportWS() {
        }

        public override void Close() {
            throw new NotImplementedException();
        }

        public override bool isConnected() {
            throw new NotImplementedException();
        }

        public override bool isDataAvailable() {
            throw new NotImplementedException();
        }

        public override void Send(byte[] data) {
            throw new NotImplementedException();
        }

        public override void SetRecieveCallback() {
            throw new NotImplementedException();
        }
    }
}
