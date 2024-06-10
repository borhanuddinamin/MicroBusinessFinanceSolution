import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { config } from './app/app.config.server';
import { HomePageComponent } from './app/home/home-page/home-page.component';
const bootstrap = () => bootstrapApplication(HomePageComponent, config);

export default bootstrap;
