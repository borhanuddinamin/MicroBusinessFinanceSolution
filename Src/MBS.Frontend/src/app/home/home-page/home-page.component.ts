import { Component } from '@angular/core';
import { NavbarComponent } from '../navbar/navbar.component';
import {MatCardModule} from '@angular/material/card';
import { SliderComponent } from '../slider/slider.component';
import { BannerComponent } from '../banner/banner.component';
import { StoreOverviewComponent } from '../store-overview/store-overview.component';
import { BlogTopContentComponent } from '../blog-top-content/blog-top-content.component';
import { FooterComponent } from '../footer/footer.component';
@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [ NavbarComponent,MatCardModule,SliderComponent,BannerComponent,FooterComponent,
    StoreOverviewComponent,BlogTopContentComponent],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {

}
