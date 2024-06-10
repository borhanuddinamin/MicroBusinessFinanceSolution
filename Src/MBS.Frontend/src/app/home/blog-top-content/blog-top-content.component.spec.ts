import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlogTopContentComponent } from './blog-top-content.component';

describe('BlogTopContentComponent', () => {
  let component: BlogTopContentComponent;
  let fixture: ComponentFixture<BlogTopContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BlogTopContentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BlogTopContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
