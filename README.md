![alt text](https://cloud.githubusercontent.com/assets/24956933/22193994/ff951596-e104-11e6-836b-4da7a4fda334.png "Sharp Scanner")

# Sharp Scanner
A robust and extensible network scanning tool. Fast, lightweight, and sports customizable settings such as scan fetchers, ping probes, and thread creation delays. This project is a GUI front end for code originally based off of the Networking library written by Oxycde which can be found here: https://github.com/Oxcyde/Networking

<b>Note</b> - <i>Sharp Scanner is retina ready and looks crisp at most resolutions!</i>

# Requirements
 - Windows 7 SP1 & Higher
 - .NET Framework 4.6.1

# References

<h3>ObjectListView</h3>
Sharp Scanner utilizes a customized ListView called ObjectListView which can be found here: http://objectlistview.sourceforge.net/cs/index.html

<h3><u> Embedded Assembly </u></h3>
ObjectListView has been embedded within the Sharp Scanner assembly and thus an extra step will be needed in order to compile the project. First, download and reference <i>ObjectListView.dll</i> from the author's homepage above. Second, add an existing file to Sharp Scanner by right-clicking on the project in the treeview and selecting the OLV DLL file. Lastly, change the <b>Build Action</b> on the added file from <i>Compile</i> to <i>Embedded Resource</i>.

# License
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

# Screenshot
![alt tag](https://cloud.githubusercontent.com/assets/24956933/22193752/2c1d7150-e103-11e6-9be1-54d9502d7dfb.png)
