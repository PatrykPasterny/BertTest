//import { Album } from "./Models/Album.js";
//import { AlbumRepository } from "./Repositories/albumRepository.js";
//export function TSButton() {
//    let albumRepo: AlbumRepository = new AlbumRepository();
//    let albums: Array<Album>;
//    albumRepo.getAlbums().then(data => {
//        albums = data;
//        let elm = document.getElementById('albumsSelector'),
//            df = document.createDocumentFragment();
//        for (var i = 0; i < albums.length; i++) {
//            let option = document.createElement('option');
//            option.value = albums[i].title;
//            option.appendChild(document.createTextNode(albums[i].title));
//            df.appendChild(option);
//        }
//        elm.appendChild(df);
//    });
//}
//(window as any).TSButton = TSButton;
function ViewAlbumButtonClicked() {
    let element = document.getElementById("selectAlbum");
    let selectedAlbumId = element.options[element.selectedIndex].value;
    var url = 'Home/DisplayAlbumPhotos';
    $('#albumPhotos').load(url, { albumId: selectedAlbumId });
}
function ViewCommentsButtonClicked(photoId) {
    var url = 'Home/DisplayPhotoComments';
    $('#photoComments').load(url, { photoId: photoId });
}
//# sourceMappingURL=app.js.map