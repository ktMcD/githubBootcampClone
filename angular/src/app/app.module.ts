import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { NgModule } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AuthorListComponent } from './author-list/author-list.component';
import { AuthorsService } from './services/authors.service';
import { EmailInputComponent } from './email-input/email-input.component';
import { PipesExampleComponent } from './pipes-example/pipes-example.component';
import { SummaryPipe } from './pipes-example/summary.pipe';
import { MaterialModule } from './material/material.module';
import { FavoriteStarComponent } from './favorite-star/favorite-star.component';
import { LikeComponent } from './like/like.component';
import { PostsComponent } from './posts/posts.component';
import { PostService } from './services/post.service';
import { StorageComponent } from './firebase/storage.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './navigation/header/header.component';
import { ZippyComponent } from './author-list/zippy/zippy.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthorListComponent,
    EmailInputComponent,
    PipesExampleComponent,
    SummaryPipe,
    FavoriteStarComponent,
    LikeComponent,
    PostsComponent,
    StorageComponent,
    HeaderComponent,
    ZippyComponent
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    FormsModule,
    FontAwesomeModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [ AuthorsService,
  PostService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
