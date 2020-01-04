<p align="center">
    <img src="https://cloud.githubusercontent.com/assets/24956933/22193994/ff951596-e104-11e6-836b-4da7a4fda334.png">
</p>

# Sharp Scanner
<p align="left">
    <!-- Version -->
    <img src="https://img.shields.io/badge/version-1.0.0-brightgreen.svg">
    <!-- Docs -->
    <img src="https://img.shields.io/badge/docs-not%20found-lightgrey.svg">
</p>

A robust and extensible network scanning tool. Fast, lightweight, and sports customizable settings such as scan fetchers, ping probes, and thread creation delays. This project is a GUI front end for code originally based off of my Forerunner library which can be found here: https://github.com/CloneMerge/Forerunner

**Note** - *Sharp Scanner is retina ready and looks crisp at most resolutions!*

### Requirements
 - Windows 7 SP1 & Higher
 - .NET Framework 4.6.1

# References

### ObjectListView
Sharp Scanner utilizes a customized ListView called ObjectListView which can be found [here]("http://objectlistview.sourceforge.net/cs/index.html") and is a fundamental dependency that is required in order to build the application from source.

### Embedded Assembly
ObjectListView has been embedded within the Auto Archiver assembly and thus an extra step will be needed in order to compile the project. First, download and reference *ObjectListView.dll* from the author's homepage above. Second, add an existing file to Auto Archiver by right-clicking on the project in the treeview and selecting the OLV DLL file. Lastly, change the ***`Build Action`*** on the added file from *`Compile`* to *`Embedded Resource`*.

# Screenshot
![alt tag](https://cloud.githubusercontent.com/assets/24956933/22193752/2c1d7150-e103-11e6-9be1-54d9502d7dfb.png)

# License
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
