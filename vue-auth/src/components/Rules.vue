<template>
  <input type="hidden" id="anPageName" name="page" value="desktop-25" />
    <div class="container-center-horizontal">
      <div class="desktop-25 screen">
        <div class="overlap-group2">
            
          <div class="ellipse-3"></div>
          <div class="ellipse-5"></div>
          <div class="ellipse-6"></div>
          <img
            class="ellipse-4" src="../assets/ellipse-4@2x.svg"
          />
          <img
            class="rectangle-24" src="../assets/rectangle-24@1x.png"
          />  
          <!--       
          <div class="overlap-group border-0-4px-white"><div class="place fredoka-normal-white-20px" @click="RegisterClick">Start</div></div>
          
          <div class="group-72">
            <div class="overlap-group1 border-0-4px-white">
              <div class="place-1 fredoka-normal-white-20px" @click="RegisterClick">Register</div>
            </div>
          </div>-->
          
          <div class="sing-in" @click="ComeBackClick"><button class="btn">Go to workspace</button></div>
          <img
            class="group-18" src="../assets/group-18@2x.svg"
          />         
          <div class="tiles" id="outtooltip">tiles          
          </div>   
                 



                 
          <div class="organize-your-ideas-projects-visually">FOLLOW OUR RULES TO CREATE YOUR NOTES

          </div>
          <div class="organize-your-ideas-projects-visually1">
            
           


  <!-- Full-width images with number and caption text -->
  
          <!--<div class="personal-workspace-favored-by-creatives">Personal workspace favored by creatives</div>-->
         <div class="rectangle-136">
             <div class="gallery">
  <a target="_blank" href="../assets/new1.jpg">
    <img src="../assets/new1.jpg" alt="Cinque Terre" width="800" height="600">
  </a>
  <div class="desc">1. Click PLUS to create your first note.</div>
</div>

<div class="gallery">
  <a target="_blank" href="../assets/new2.jpg">
    <img src="../assets/new2.jpg" alt="Forest" width="800" height="600">
  </a>
  <div class="desc">2. This is how your basic note looks like.</div>
</div>

<div class="gallery">
  <a target="_blank" href="../assets/new3.jpg">
    <img src="../assets/new3.jpg" alt="Northern Lights" width="800" height="600">
  </a>
  <div class="desc">3. Write the name of your note instead Untitled. Reload your page.</div>
</div>

<div class="gallery">
  <a target="_blank" href="../assets/new4.jpg">
    <img src="../assets/new4.jpg" alt="Mountains" width="800" height="1000">
  </a>
  <div class="desc">4. Click Link Sign and copy-paste your link to the special textarea. Click outside of the linkfield.</div>
</div>
<div class="gallery">
  <a target="_blank" href="../assets/new5.jpg">
    <img src="../assets/new5.jpg" alt="Mountains" width="800" height="1000">
  </a>
  <div class="desc">5. To add text - click Plus. In the textarea write your note. Click outside. Your text will be saved.</div>
</div>

<div class="gallery">
  <a target="_blank" href="../assets/new6.jpg">
    <img src="../assets/new6.jpg" alt="Mountains" width="800" height="1000">
  </a>
  <div class="desc">6. To add a picture - click Image. Download a picture from your PC. </div>
</div>
            
          </div>
               <!--<iframe width="700" height="415" 
               src="https://www.youtube.com/embed/H7bOtuZtiXk" 
               title="YouTube video player"
                frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>-->         
          
          </div>  
          <div class="ellipse-7">            
          </div>
          <div class="ellipse-8"></div>
          <img
            class="rectangle-137" src="../assets/rectangle-137@1x.png"
          />
          
          
         <div class="x screen">
         <div class="overlap-group4201">
          <div class="view201">
            <div class="overlap-group1201">
              <img
                class="mask-group201"
                src="../assets/mask-group-62@2x.svg"
              />
              <div class="flex-col201">
                <div class="getting-starter fredoka-normal-malibu-14-6px-3" id="correction">Getting starter</div>
                <div class="note-creation-guide fredoka-light-black-11-7px-32">Note creation guide</div>
              </div>
            </div>
          </div>
          <div class="overlap-group2201">
            <img
              class="image-10201"
              src="../assets/image-10@2x.png"
            />
            <div class="flex-col-1201">
              <div class="get-help fredoka-normal-black-14-6px-3">Get help</div>
              <p class="ask-us-a-question-here fredoka-light-black-11-7px-2">Ask us a question here</p>
            </div>
          </div>
          <div class="overlap-group3201">
            <div class="group-137201">
              <img
                class="image-12201"
                src="../assets/image-11@2x.png"
              />
            </div>
            <div class="flex-col-2201">
              <div class="resources fredoka-normal-black-14-6px-2">Resources</div>
              <p class="learn-how-to-use-x-tiles fredoka-light-black-11-7px-3">Learn how to use xTiles</p>
            </div>
          </div>
        </div>
        </div>
          <img
            class="group-73201" src="../assets/group-73@2x.svg"
          />

          
        </div>
      </div>
      </div>
    <div id="app">   
  </div>
</template>


<script>
import {mapGetters} from 'vuex'
import Userfront from "@userfront/core"
    export default 
    {
             name:'RULES',
             computed: {
        ...mapGetters(['username']),
        isLoggedOut() {
       return !Userfront.tokens.accessToken;
    },
            },
             
             data(){
                return{   
                    return: 'username',

                     
                    
                }
             },
             methods:{           
            ComeBackClick(){
               this.$router.push('/workspace');
            },
    
     
    },
  }
    
    
    
</script>



<style  scoped>
.btn{
    background:lightblue;
    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    color:#0a54e2;
    border-radius:4px;
}
/*Gallery*/
.desktop-25 .rectangle-136 {
  background-color: rgba(173, 230, 228, 0.677);
  border-radius: 12px;
  box-shadow: 0px 4px 0px #8ba8de;
  height: 700px;
  left: -250px;
  position: absolute;
  top: -150px;
  width:1000px;
}
div.gallery {
  margin: 8px;
  border: 1px solid #ccc;
  float: left;
  width: 300px;
  height:310px;
}

div.gallery:hover {
  border: 1px solid #777;
}

div.gallery img {
  width: 100%;
  height: auto;
}

div.desc {
  padding: 15px;
  text-align: center;
  
}
/*Gallery*/





/*RULES*/
.imgCustom {
  border: 2px solid rgb(221, 221, 221);
  border-radius: 5px;
  padding: 10px;
  width: 200px;
  margin-left:300px;
}
.desktop-25 .organize-your-ideas-projects-visually {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl);
  font-weight: 1000;
  left: 680px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 80px;
  width: 344px;
  color:blueviolet;
  border-color:blue;
  border-radius:3px;
}
.desktop-25 .organize-your-ideas-projects-visually1 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl);
  font-weight: 600;
  left: 580px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 270px;
  width: 344px;
  color:blue;
  
}

@import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

@import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");

.screen a {
  display: contents;
  text-decoration: none;
}
.x {
  align-items: flex-start;
  background-color: var(--mystic);
  display: flex;
  height: 1024px;
  overflow: hidden;
  width: 1440px;
}

#correction{
    margin-left:3px;
}
.container-center-horizontal {
  display: flex;
  flex-direction: row;
  justify-content: center;
  pointer-events: none;
  width: 100%;
}

.container-center-horizontal > * {
  flex-shrink: 0;
  pointer-events: auto;
}

.overlay {
  display: none;
  height: 100%;
  opacity: 0;
  position: fixed;
  top: 0;
  width: 100%;
}

.overlay.animate-appear {
  animation: reveal 0.3s ease-in-out 1 normal forwards;
  display: block;
  opacity: 0;
}

.overlay.animate-disappear {
  animation: reveal 0.3s ease-in-out 1 reverse forwards;
  display: block;
  opacity: 1;
  pointer-events: none;
}

.overlay.animate-disappear * {
  pointer-events: none;
}

* {
  box-sizing: border-box;
}


.fredoka-medium-black-30px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-style: normal;
  font-weight: 500;
}

.fredoka-normal-malibu-14-6px-3 {
  color: var(--malibu);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-s);
  font-style: normal;
  font-weight: 400;
}

.fredoka-light-black-11-7px-32 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxs);
  font-style: normal;
  font-weight: 300;
}

.fredoka-normal-black-14-6px-3 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-s);
  font-style: normal;
  font-weight: 400;
}

.fredoka-light-black-11-7px-2 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxs);
  font-style: normal;
  font-weight: 300;
}

.fredoka-normal-black-14-6px-2 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-s);
  font-style: normal;
  font-weight: 400;
}

.fredoka-light-black-11-7px-3 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxs);
  font-style: normal;
  font-weight: 300;
}

.fredoka-light-gray-12px {
  color: var(--gray);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xs);
  font-style: normal;
  font-weight: 300;
}

.fredoka-bold-white-30px {
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-style: normal;
  font-weight: 700;
}







.overlap-group4201 {
  height: 1118px;
  margin-left: 150px;
  margin-top: 500.24px;
  position: relative;
  width: 1678px;
  z-index: 1;
}

 .ellipse-3201 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 179.63px;
  height: 359px;
  left: 37px;
  position: absolute;
  top: 37px;
  transform: rotate(13.71deg);
  width: 359px;
}

 .ellipse-5201 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 143.16px;
  height: 286px;
  left: 1339px;
  position: absolute;
  top: 590px;
  transform: rotate(-120.00deg);
  width: 286px;
}

 .ellipse-6201 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 117.04px;
  height: 234px;
  left: 1252px;
  position: absolute;
  top: 721px;
  transform: rotate(-60.00deg);
  width: 234px;
}

 .ellipse-4201 {
  height: 359px;
  left: 88px;
  position: absolute;
  top: 196px;
  width: 259px;
}

 .rectangle-24201 {
  -webkit-backdrop-filter: blur(15px) brightness(100%);
  backdrop-filter: blur(15px) brightness(100%);
  background-color: var(--white-3);
  border: 2px solid;
  border-color: var(--white);
  border-radius: 13px;
  height: 1024px;
  left: 108px;
  position: absolute;
  top: 94px;
  width: 1402px;
}

.line-1201 {
  height: 1px;
  left: 150px;
  position: absolute;
  top: 149px;
  width: 1316px;
}

 .group-18201 {
  cursor: pointer;
  height: 82px;
  left: 767px;
  position: absolute;
  top: 179px;
  width: 82px;
}

 .title201 {
  left: 729px;
  letter-spacing: 0;
  position: absolute;
  top: 266px;
  width: 158px;
}

 .rectangle-126201 {
  background-color: var(--white);
  border: 0.4px solid;
  border-color: var(--glacier);
  border-radius: 13px;
  height: 31px;
  left: 991px;
  position: absolute;
  top: 107px;
  width: 198px;
}

 .group-136201 {
  align-items: flex-start;
  background-color: var(--white);
  display: flex;
  height: 19px;
  justify-content: flex-end;
  left: 1158px;
  min-width: 21px;
  padding: 2.0px 2.7px;
  position: absolute;
  top: 113px;
}

 .overlap-group201 {
  height: 15px;
  position: relative;
  width: 15px;
}

.ellipse-43201 {
  border: 1px solid;
  border-color: var(--glacier);
  border-radius: 5.73px/5.59px;
  height: 11px;
  left: 0;
  position: absolute;
  top: 0;
  width: 11px;
}

 .line-9201 {
  height: 6px;
  left: 9px;
  position: absolute;
  top: 9px;
  width: 6px;
}

 .view201 {
  align-items: flex-start;
  cursor: pointer;
  display: flex;
  height: 65px;
  left: 228px;
  min-width: 270px;
  position: absolute;
  top: 349px;
}

 .overlap-group1201 {
  align-items: center;
  background-color: var(--white-5);
  border-radius: 9.47px;
  display: flex;
  height: 65px;
  min-width: 266px;
  padding: 11.6px 52.9px;
}

 .mask-group201 {
  align-self: flex-end;
  height: 42px;
  width: 42px;
}

 .flex-col201 {
  align-items: flex-start;
  display: flex;
  flex-direction: column;
  margin-bottom: 1.18px;
  margin-left: 6px;
  min-height: 33px;
  width: 112px;
}

 .getting-starter201 {
  letter-spacing: 0;
  min-height: 17px;
  width: 109px;
}

 .note-creation-guide {
  letter-spacing: 0;
  margin-left: 4.55px;
  min-height: 16px;
  width: 107px;
}

.x .overlap-group2201 {
  align-items: center;
  background-color: var(--white-5);
  border-radius: 9.47px;
  display: flex;
  height: 65px;
  justify-content: flex-end;
  left: 526px;
  min-width: 266px;
  padding: 0 41.6px;
  position: absolute;
  top: 349px;
}

 .image-10201 {
  height: 42px;
  object-fit: cover;
  width: 42px;
}

 .flex-col-1201 {
  align-items: flex-start;
  display: flex;
  flex-direction: column;
  margin-bottom: 1.18px;
  margin-left: 9px;
  min-height: 33px;
  width: 123px;
}

.get-help201 {
  letter-spacing: 0;
  min-height: 17px;
  width: 61px;
}

 .ask-us-a-question-here201 {
  letter-spacing: 0;
  min-height: 16px;
  width: 123px;
}

.overlap-group3201 {
  align-items: flex-start;
  background-color: var(--white-5);
  border-radius: 9.47px;
  display: flex;
  height: 65px;
  left: 824px;
  min-width: 266px;
  padding: 7.2px 40.5px;
  position: absolute;
  top: 349px;
}

 .group-137201 {
  align-items: flex-start;
  background-image: url(https://anima-uploads.s3.amazonaws.com/projects/630cefa5a839203234c33557/releases/630cefe0260e835b228e4406/img/image-11@2x.png);
  background-position: 50% 50%;
  background-size: cover;
  display: flex;
  min-width: 51px;
  opacity: 0.5;
}

.image-12201 {
  height: 51px;
  margin-top: 0;
  object-fit: cover;
  width: 51px;
}

.flex-col-2201 {
  align-items: flex-start;
  align-self: center;
  display: flex;
  flex-direction: column;
  margin-bottom: 1.18px;
  margin-left: 4px;
  min-height: 33px;
  width: 123px;
}

.resources201 {
  letter-spacing: 0;
  min-height: 17px;
  width: 70px;
}

.learn-how-to-use-x-tiles201 {
  letter-spacing: 0;
  min-height: 16px;
  width: 123px;
}

 .tags201 {
  left: 915px;
  letter-spacing: 0;
  position: fixed;
  top: 19px;
  width: 40px;
  z-index: 3;
}

.group-10201 {
  align-items: center;
  box-shadow: 0px 2px 2px #5cffdd;
  display: flex;
  height: 34px;
  left: 1133px;
  min-width: 165px;
  position: fixed;
  top: 10px;
  z-index: 2;
}

 .overlap-group-1201 {
  align-self: flex-end;
  height: 34px;
  margin-bottom: 0;
  position: relative;
  width: 27px;
}

 .rectangle-9201 {
  background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
  border: 0.3px solid;
  border-color: var(--fresh-air);
  border-radius: 13px;
  height: 27px;
  left: 0;
  position: absolute;
  top: 5px;
  width: 27px;
}

 .text-1201 {
  -webkit-background-clip: text !important;
  -webkit-text-fill-color: transparent;
  background: linear-gradient(180deg, rgb(39.91, 92.81, 195.5) 0%, rgba(107.09, 43.24, 157.25, 0) 100%);
  background-clip: text;
  left: 7px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  text-fill-color: transparent;
  top: 0;
  width: 13px;
}

 .group-12201 {
  align-items: flex-start;
  background: linear-gradient(180deg, rgba(246, 246, 249, 0.27) 0%, rgb(255, 255, 255) 0.01%, rgb(232, 241, 253) 100%);
  border: 0.3px solid;
  border-color: var(--fresh-air);
  border-radius: 13px;
  display: flex;
  height: 27px;
  margin-left: 19px;
  margin-top: 3.18px;
  min-width: 27px;
  padding: 3.9px 4.4px;
}

 .icon-star201 {
  height: 17px;
  width: 18px;
}

 .group-13201 {
  align-items: flex-start;
  background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
  border: 0.3px solid;
  border-color: var(--fresh-air);
  border-radius: 13px;
  display: flex;
  height: 27px;
  margin-left: 19px;
  margin-top: 3.18px;
  min-width: 27px;
  padding: 5.4px 4.9px;
}

.mask-group-1201 {
  height: 16px;
  width: 17px;
}

 .group-14201 {
  background: linear-gradient(180deg, rgba(248.63, 248.63, 248.63, 0) 0%, rgb(219.94, 236.07, 255) 100%);
  background-image: url(https://anima-uploads.s3.amazonaws.com/projects/630cefa5a839203234c33557/releases/630cefe0260e835b228e4406/img/mask-group-63@2x.svg);
  background-size: 100% 100%;
  border: 0.3px solid;
  border-color: var(--fresh-air);
  border-radius: 13px;
  height: 27px;
  margin-left: 19px;
  margin-top: 2.58px;
  width: 27px;
}

/*RULES*/













#outtooltip {
  position: relative;
  display: inline-block;
  
}
#outtooltip #tooltiptext {
  
  width: 300px;
  background-color: lightskyblue;
  color: darkblue;
  text-align: center;
  border-radius: 20px;
  margin-left: 10px;
  padding: 5px 5px;
  visibility: visible;
  /* Position the tooltip */
  position: absolute;
  z-index: 1;
}



/* @import url('https://fonts.googleapis.com/css?family=Fira+Sans:400,500,600,700,800');
*{
  box-sizing:border-box;
} */
@import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

@import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");

.screen a {
  display: contents;
  text-decoration: none;
}

.container-center-horizontal {
  display: flex;
  flex-direction: row;
  justify-content: center;
  pointer-events: none;
  width: 100%;
}

.container-center-horizontal > * {
  flex-shrink: 0;
  pointer-events: auto;
}

* {
  box-sizing: border-box;
}

:root { 
  --black: #000000;
  --malibu: #79a8f9;
  --mystic: #e3e8ee;
  --white: #ffffff;
  --white-4: #ffffffb2;
 
  --font-size-l: 22.7px;
  --font-size-s: 15px;
  --font-size-xl: 33px;
  --font-size-xl2: 20px;
  --font-size-xxl: 35.8px;
 
  --font-family-fredoka: "Fredoka", Helvetica;
}
.fredoka-light-white-15px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-s);
  font-style: normal;
  font-weight: 300;
}

.fredoka-normal-white-20px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-style: normal;
  font-weight: 400;
  cursor:pointer;
}

.fredoka-normal-black-20px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-style: normal;
  font-weight: 400;
}

.border-0-4px-white {
  border: 0.4px solid var(--white);
}


.desktop-25 {
  align-items: flex-start;
  /*background-color: var(--mystic);
  background-color:lightblue;*/
   background-color: #e3e8ee;
  display: flex;
  overflow: hidden;
  /*width: 1440px;*/
  width: 1520px;
  
}

.desktop-25 .overlap-group2 {
  height: 1066px;
  margin-left: -89px;
  position: relative;
  width: 1529px;
}

.desktop-25 .ellipse-3 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 179.63px;
  height: 359px;
  left: 37px;
  position: absolute;
  top: 53px;
  transform: rotate(13.71deg);
  width: 359px;
}

.desktop-25 .ellipse-5 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 143.16px;
  height: 286px;
  left: 534px;
  position: absolute;
  top: 382px;
  transform: rotate(60.00deg);
  width: 286px;
}

.desktop-25 .ellipse-6 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 117.04px;
  height: 234px;
  left: 674px;
  position: absolute;
  top: 303px;
  transform: rotate(120.00deg);
  width: 234px;
}

.desktop-25 .ellipse-4 {
  height: 359px;
  left: 89px;
  position: absolute;
  top: 211px;
  width: 258px;
}

.desktop-25 .rectangle-24 {
  height: 1000px;
  /*height: 1066px;*/
  left: 150px;
  top: 20px;
  width: 1402px;
  position: absolute;
  
   
}

.desktop-25 .overlap-group {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  align-items: flex-start;
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  display: flex;
  height: 37px;
  left: 395px;
  min-width: 124px;
  padding: 5.3px 37.0px;
  position: absolute;
  top: 381px;
}

.desktop-25 .place {
  letter-spacing: 0;
  min-height: 24px;
  text-align: center;
  width: 49px;
}

.desktop-25 .group-72 {
  align-items: flex-start;
  cursor: pointer;
  display: flex;
  height: 37px;
  left: 1223px;
  min-width: 169px;
  position: absolute;
  top: 22px;
}

.desktop-25 .overlap-group1 {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  align-items: flex-start;
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  display: flex;
  height: 37px;
  min-width: 167px;
  padding: 5.3px 43.9px;
}

.desktop-25 .place-1 {
  letter-spacing: 0;
  min-height: 24px;
  text-align: center;
  width: 78px;
}

.desktop-25 .sing-in {
  color: var(--malibu);
  cursor: pointer;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 400;
  left: 1143px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 40px;
  width: 200px;
  border:#0a54e2;
}

.desktop-25.sing-inn{
  color: var(--malibu);
  cursor: pointer;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 400;
  left: 2000px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 27px;
  width: 78px;
}

.desktop-25 .group-18 {
  height: 70px;
  left: 220px;
  position: absolute;
  top: 45px;

  width: 70px;
}

.desktop-25 .tiles {
  color: #0a54e2;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-l);
  font-weight: 500;
  left: 300px;
  letter-spacing: 0;
  position: absolute;
  top: 90px;
  width: 49px;
}



.desktop-25 .personal-workspace-favored-by-creatives {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 300;
  left: 269px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 324px;
  width: 377px;
}



/*.desktop-25 .polygon-1 {
  height: 82px;
  left: 1016px;
  position: absolute;
  top: 298px;
  width: 72px;
}*/

.desktop-25 .ellipse-7 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 91.52px;
  height: 183px;
  left: 1279px;
  position: absolute;
  top: 96px;
  transform: rotate(-63.00deg);
  width: 183px;
}

.desktop-25 .ellipse-8 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 44.95px;
  height: 90px;
  left: 1397px;
  position: absolute;
  top: 224px;
  transform: rotate(-10.02deg);
  width: 90px;
}

.desktop-25 .rectangle-137 {
  height: 422px;
  
  left: 91px;
  position: absolute;
  top: 644px;
  /*width: 1439px;*/
  width: 1515px;
}

.desktop-25 .copyright {
  left: 234px;
  letter-spacing: 0;
  position: absolute;
  top: 948px;
  width: 140px;
}

.desktop-25 .privacy-policy {
  left: 433px;
  letter-spacing: 0;
  position: absolute;
  top: 950px;
  width: 99px;
}

.desktop-25 .public-offer {
  left: 562px;
  letter-spacing: 0;
  position: absolute;
  top: 950px;
  width: 77px;
}

.desktop-25 .cookies {
  left: 669px;
  letter-spacing: 0;
  position: absolute;
  top: 951px;
  width: 58px;
}

.desktop-25 .group-73 {
  height: 51px;
  left: 229px;
  position: absolute;
  top: 845px;
  width: 51px;
}

.desktop-25 .title {
  color: #0a54e2;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-weight: 500;
  left: 287px;
  letter-spacing: 0;
  position: absolute;
  top: 846px;
  width: 78px;
}

.desktop-25.back{
    background-color: aquamarine;
}

</style>
