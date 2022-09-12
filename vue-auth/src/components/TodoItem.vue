<template>
    <input type="hidden" id="anPageName" name="page" value="9_644" />
    <div class="view">
        <div class="overlap-group3 border-0-4px-black">
            <!--<Userpage v-bind:title="this.title" v-bind:addnew="this.addnew"></Userpage>--><!--перенос-->
            <div class="flex-row">
                <div class="untitled fredoka-medium-black-17px">
                    <span v-if="!editing" v-on:click="editName()">
                        {{name}}
                    </span>
                    <span v-if="editing">
                        <input class="tytleSt" v-model="name" v-on:blur="save_name">
                    </span>
                </div>



                <img class="mask-group" src="../assets/mask-group-4@2x.svg"
                     @click="$emit('remove')" />
            </div>

            <div class="flex-row-1">
                <select v-model="select" class="overlap-group4 border-0-2px-black" @change="add_tag()">
                    <option value="" disabled hidden>Choose a tag</option>
                    <option value="add tag">add tag</option>
                    <option v-for="item in alltags" :value="item.tag" :key="item.tag">{{item.tag}}</option>
                </select>
                <input v-show="visible" v-model="newtag" v-on:blur="add_newtag">
                <!--<input ref="tagfocus" v-show="visible" v-model="newtag" v-on:blur="add_newtag">-->
            </div>

            <div class="flex-row-1">
                <div class="date">{{createdPage}}</div>
                <img class="vector-8" src="../assets/vector-8@2x.svg" />
                <!--<div class="movies">-->
                <div class="movies fredoka-light-gray-12px">
                    <span class="movies" v-for="item in group" :key="item">
                        #{{item}}
                        <span class="movies button1" v-on:click="del_tag(item)">
                            &nbsp;&nbsp;&nbsp;&nbsp;X
                        </span>
                    </span>
                    <!--<img class="vectorCustom" src="../assets/vector-8@2x.svg" />-->
                </div>
            </div>

            <div class="fredoka-light-black-15px">
                <!--{{ records }}-->
                <record-item v-for="(record) in records"
                             :key="record.id"
                             :text="record.text"
                             :imageId="record.imageId"
                             :type="record.recordType"
                             :recordId="record.id"
                             :pageId="pageId"></record-item>

                <component v-bind:is="component"></component>
                <span v-if="creating_text">
                    <textarea id="textArea" v-model="message" placeholder="Text.." v-on:blur="add_text"></textarea>
                </span>

                <span v-if="creating_url">
                    <input v-model="message" placeholder="Link.." v-on:blur="add_url">
                    <!--<textarea id="textArea" v-model="message" placeholder="Link.." v-on:blur="add_url"></textarea>-->
                </span>


            </div>

            <!--<form method="post" enctype="multipart/form-data">-->

            <div class="group-container">
                <div id="outtooltip">
                    <img class="mask-group-1" src="../assets/mask-group-3@2x.svg" />
                    <!--<span id="tooltiptext"><input type="file" id="file" ref="file" v-on:change="handleFileUpload()"/></span>-->
                    <span id="tooltiptext2"><input type="file" @change="onFile" /></span>
                </div>
                <div class="group-133">
                    <div class="overlap-group1" v-on:click="create_text">
                        <div class="overlap-group" id="outtooltip">
                            <div class="rectangle-39 border-0-9px-black-3"></div>
                            <div class="rectangle-37 border-0-9px-black-4"></div>
                            <span id="tooltiptext3">Add Text</span>
                        </div>
                        <img class="line-5" src="../assets/line-5@2x.svg" />
                        <img class="line-6" src="../assets/line-6@2x.svg" />
                    </div>
                </div>
                <div class="group-132">
                    <div class="overlap-group2">
                        <!--<img click="SaveInFile"
                          class="arrow-1" id="arrow" src="../assets/arrow-1@2x.svg"
                        />-->
                        <img class="ellipse-42" id="arrow" click="SaveInFile" src="../assets/arrow-1@2x.svg" />
                    </div>

                </div>
                <div id="outtooltip">
                    <img class="group-136" src="../assets/group-136-2@2x.svg" v-on:click="create_url" />
                    <span id="tooltiptext4">Add Link</span>
                </div>


                <!--<textarea id="textArea" v-model="message" placeholder="link.." v-on:blur="add_text"></textarea>
                />-->
                <!--ДИСКЕТА-->
                <!--<div class="group-1351" v-on:click="create_file">-->
                <div id="outtooltip">
                    <div class="group-1351" id="outtooltip">
                        <!--<span id="tooltiptext">
                            <input type="file" @change="create_file">
                        </span>-->
                        <div class="overlap-group31">
                            <div class="overlap-group-11">
                                <div class="rectangle-1341"></div>
                            </div>
                            <div class="rectangle-1321"></div>
                        </div>

                    </div>
                    <span id="tooltiptext2"><input type="file" @change="create_file" /></span>


                </div>
            </div>
            <!--<div class="imgset"><img :src="imgSrc" v-if="imgSrc" class="mypic" /> </div>-->
            <!-- <div class="preview">
              <p>No files currently selected for upload</p>
            </div>
            <div>
              <button>Submit</button>
            </div>-->
            <!--</form> -->
        </div>

    </div>
</template>


<script>
    //import axios from 'axios'
    import Userpage from "./Userpage"
    import axios from 'axios'
    import RecordItem from './RecordItem'


    export default {
        name: 'TODOITEM',
        props: ['title', 'records', 'createdPage', 'pageId', 'group', 'alltags'],
        emits: ['remove', 'refresh'],


        data() {
            return {
                message: '',
                /* imgSrc: '',*/
                select: '',
                editing: false,
                creating_text: false,
                creating_url: false,
                visible: false,
            }
        },
        async created() {
            this.name = this.title;
        },

        methods: {
            editName() {
                this.editing = true;
            },

            async save_name() {
                try {
                    await axios.put('api/Page/Rename',
                        {
                            newName: this.name,
                            IdPage: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });

                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
                this.editing = false;
                //alert(
                //    this.message);
            },

            async onFile(e) {
                const files = e.target.files
                if (!files.length) return

                const reader = new FileReader()
                reader.readAsDataURL(files[0])
                /* reader.onload = () => (this.imgSrc = reader.result)*/
                try {
                    await axios.post('api/Record/CreateImage',
                        {
                            File: files[0],
                            PageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`,
                            "Content-Type": "multipart/form-data"
                        }
                    });
                    this.$emit('refresh');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
            },

            create_text() {
                this.creating_text = true;
            },
            async add_text() {
                try {
                    await axios.post('api/Record/CreateText',
                        {
                            Text: this.message,
                            PageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });
                    this.message = "";
                    this.$emit('refresh');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
                this.creating_text = false;
            },

            create_url() {
                this.creating_url = true;
            },
            async add_url() {
                try {
                    await axios.post('api/Record/CreateUrl',
                        {
                            Text: this.message,
                            PageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });
                    this.message = "";
                    this.$emit('refresh');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
                this.creating_url = false;
            },

            async add_tag() {
                if (this.select == "add tag") {
                    this.visible = true;
                    //    this.$refs.tagfocus.focus();
                }
                else {
                    this.visible = false;
                    try {
                        await axios.post('api/Page/CreateTag',
                            {
                                Group: this.select,
                                IdPage: this.pageId,
                            }, {
                            headers: {
                                'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                            }
                        });
                        this.select = "";
                        this.$emit('refresh');
                    } catch (e) {
                        this.error = 'Invalid!';
                        console.log(e);
                    }
                }
            },

            async create_file(e) {
                const files = e.target.files
                if (!files.length) return

                const reader = new FileReader()
                reader.readAsDataURL(files[0])
                /* reader.onload = () => (this.imgSrc = reader.result)*/
                try {
                    await axios.post('api/Record/CreateFile',
                        {
                            File: files[0],
                            PageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`,
                            "Content-Type": "multipart/form-data"
                        }
                    });
                    this.$emit('refresh');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
            },

            async add_newtag() {
                this.visible = false;
                try {
                    await axios.post('api/Page/CreateTag',
                        {
                            Group: this.newtag,
                            IdPage: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });
                    this.select = "";
                    this.$emit('refresh');
                    this.$emit('refreshTags');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
            },

            async del_tag(tag) {
                try {
                    await axios.delete('api/Page/DeleteTag',
                        {
                            data: {
                                Group: tag,
                                IdPage: this.pageId,
                            },
                            headers: {
                                'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                            }
                        });
                    this.select = "";
                    this.$emit('refresh');
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
            }

            /*submitFile(){
                        let formData = new FormData();
                        formData.append('file', this.file);
                        axios.post( '/single-file',
                            formData,
                            {
                            headers: {
                                'Content-Type': 'multipart/form-data'
                            }
                          }
                        ).then(function(){
                      console.log('SUCCESS!!');
                    })
                    .catch(function(){
                      console.log('FAILURE!!');
                    });
                  },
                  handleFileUpload(){
                    this.file = this.$refs.file.files[0];
                  }*/
        },
        components:
            { Userpage, RecordItem }

    }



</script>


<style scoped>
    .group-1351 {
        align-items: flex-end;
        display: flex;
        cursor: pointer;
        height: 16px;
        min-width: 16px;
        margin-left: 14px;
        margin-top: 4px;
         /* bottom: 20px;
        left: 150px;
        margin-left: 14px;
        margin-top: 4px;*/
        /*position: absolute;*/
        /*left: 21px;*/
        /*top: 63px;*/
    }

    .overlap-group31 {
        align-items: flex-start;
        display: flex;
        flex-direction: column;
        background-image: url(../assets/vector-10@2x.svg);
        background-size: 100% 100%;
        margin-bottom: -0.35px;
        min-height: 15px;
        padding: 0.1px 2.9px;
        width: 17px;
    }

    .overlap-group-11 {
        align-items: flex-start;
        border: 1px solid;
        border-color: darkgray;
        border-radius: 0.5px;
        display: flex;
        height: 7px;
        justify-content: flex-end;
        margin-left: 1.64px;
        min-width: 8px;
        padding: 1.1px 2.0px;
    }

    .rectangle-1341 {
        background-color: var(--gray);
        /*border: 1px none;*/
        border: 0.5px solid;
        height: 3px;
        width: 2px;
    }

    .rectangle-1321 {
        border: 0.8px solid;
        border-color: var(--gray);
        border-radius: 0.5px;
        height: 5px;
        margin-top: 1px;
        width: 11px;
    }

    .vectorCustom {
        height: 14px;
        margin-bottom: 0.14px;
        margin-left: 2px;
        width: 1px;
    }

    group-136 {
        height: 15px;
        margin-bottom: 0;
        margin-left: 12px;
        width: 15px;
    }

    input:focus, textarea:focus, select:focus {
        outline: none;
    }

    .tytleSt {
        width: 80px;
        border: hidden;
    }

    .mypic {
        max-width: 100%;
        height: auto;
        width: auto\9;
        min-height: 100px;
        min-width: 100px;
    }

    .imgset {
        display: flex;
        justify-content: center;
        margin-top: 10px;
        max-width: 900px;
    }

    #outtooltip {
        position: relative;
        display: inline-block;
    }

        #outtooltip #tooltiptext {
            visibility: hidden;
            width: 120px;
            background-color: rgba(0, 0, 0, 0.322);
            color: #fff;
            text-align: center;
            border-radius: 6px;
            border-color: black;
            padding: 5px 0;
            /* Position the tooltip */
            position: absolute;
            z-index: 1;
        }

        #outtooltip:hover #tooltiptext {
            visibility: visible;
            cursor: pointer;
        }

        /*ВТОРОЙ  ХОВЕР */
        #outtooltip #tooltiptext2 {
            visibility: hidden;
            width: 0.1px;
            /*border-radius: 6px;*/
            background-color: rgba(0, 0, 0, 0.322);
            color: #fff;
            text-align: center;
            border-color: rgba(16, 75, 223, 0.533);
            padding: 5px 0;
            /* Position the tooltip */
            position: absolute;
            z-index: 1;
        }

        #outtooltip:hover #tooltiptext2 {
            visibility: visible;
            cursor: pointer;
        }


        /*ТРЕТИЙ  ХОВЕР */
        #outtooltip #tooltiptext3 {
            visibility: hidden;
            width: 70px;
            /*border-radius: 6px;*/
            background-color: lightgray;
            color: black;
            text-align: center;
            height: 18px;
            border-color: black;
            padding: 2px 0;
            /* Position the tooltip */
            position: absolute;
            z-index: 1;
        }

        #outtooltip:hover #tooltiptext3 {
            visibility: visible;
            cursor: pointer;
            margin-top: 20px;
            background-color: lightgray;
            color: black;
            text-align: center;
            border-color: black;
            border-radius: 2px;
            border-width: 2px;
        }
        /*ЧЕТВЕРТЫЙ  ХОВЕР */
        #outtooltip #tooltiptext4 {
            visibility: hidden;
            width: 70px;
            /*border-radius: 6px;*/
            background-color: lightgray;
            color: black;
            text-align: center;
            height: 18px;
            border-color: black;
            padding: 2px 0;
            /* Position the tooltip */
            position: absolute;
            z-index: 1;
        }

        #outtooltip:hover #tooltiptext4 {
            visibility: visible;
            cursor: pointer;
            margin-top: 20px;
            background-color: lightgray;
            color: gray;
            text-align: center;
            border-color: black;
            border-radius: 2px;
            border-width: 2px;
        }



    textarea {
        width: 200px;
        height: 60px;
        resize: both;
    }

    .view {
        align-items: flex-start;
        /*display: flex;
                                    height: 192px;
                                    */
        overflow: hidden;
        padding: 0.6px 0;
        /* width: 265px;*/
        min-height: 192px;
        min-width: 265px;
        padding: 10px;
        margin: 10px;
        display: inline-block;
    }

    .overlap-group3 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        align-items: flex-start;
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white);
        border-radius: 13px;
        box-shadow: 0px 4px 0px #8aa7de;
        /*display: flex;
        flex-direction: column;
        min-height: 187px;*/
        padding: 14.0px 19.7px;
        width: 265px;
        flex-direction: column;
        /* НИЖЕ ДОБАВЛЕНЫ УВЕЛИЧЕНИЯ ТАЙЛА */
        resize: both;
        display: inline-block;
        overflow: auto;
        min-width: 150px;
        min-height: 150px;
        max-width: 1026px;
        max-height: 750px;
    }

    .flex-row {
        align-items: flex-start;
        align-self: center;
        display: flex;
        height: 21px;
        margin-left: 0.08px;
        min-width: 225px;
    }

    .untitled {
        letter-spacing: 0;
        min-height: 20px;
        width: 250px;
    }

    .overlap-group4 {
        align-items: flex-start;
        align-self: flex-end;
        background-color: var(--white);
        border-radius: 5px;
        display: flex;
        height: 19px;
        justify-content: flex-end;
        /*        margin-left: 21px;
        */ min-width: 112px;
        padding: 0px 4.0px;
        margin: -5px;
        border: 0.4px solid var(--gray);
        color: gray;
        font-size: 14px;
    }

    .group-134 {
        align-items: flex-end;
        background-color: var(--white);
        display: flex;
        height: 11px;
        min-width: 15px;
        padding: 3.2px 2.7px;
    }

    .vector-9 {
        height: 3px;
        width: 9px;
    }

    .mask-group {
        align-self: center;
        height: 18px;
        margin-left: 17px;
        margin-top: 0.89px;
        width: 18px;
        cursor: pointer;
    }

    .flex-row-1 {
        align-items: flex-end;
        display: flex;
        height: 20px;
        /*height: 16px;*/
        margin-left: 0.4px;
        margin-top: 6px;
        min-width: 98px;
        /*margin-top: 1px;*/
    }

    .date {
        color: var(--gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xs);
        font-weight: 300;
        letter-spacing: 0;
        min-height: 14px;
        width: 40px;
    }

    .vector-8 {
        height: 14px;
        margin-bottom: 0.14px;
        margin-left: 25px;
        width: 1px;
    }

    .movies {
        align-self: flex-start;
        letter-spacing: 0;
        min-height: 16px;
        margin-left: 2px;
        margin-top: -7px;
        padding-top: 5px;
        width: 70px;
        display: flex;
        flex-direction: row;
    }

    .text {
        letter-spacing: 0;
        margin-top: 8px;
        min-height: 16px;
        width: 39px;
    }

    .group-container {
        align-items: flex-start;
        display: flex;
        margin-left: 0.88px;
        margin-top: 30px; /* изменено  74px; / 40 px  */
        min-width: 88px;
    }

    .mask-group-1 {
        height: 21px;
        width: 21px;
        cursor: pointer;
    }

    .group-133 {
        align-items: flex-start;
        align-self: flex-end;
        display: flex;
        margin-bottom: 0;
        margin-left: 13px;
        min-width: 22px;
        opacity: 0.5;
    }

    .overlap-group1 {
        height: 20px;
        position: relative;
        width: 22px;
        cursor: pointer;
    }

    .overlap-group {
        height: 20px;
        left: 0;
        position: absolute;
        top: 0;
        width: 22px;
    }

    .rectangle-39 {
        border-radius: 3.98px;
        height: 15px;
        left: 0;
        position: absolute;
        top: 0;
        width: 15px;
    }

    .rectangle-37 {
        background-color: var(--white);
        border-radius: 5.31px;
        height: 17px;
        left: 5px;
        position: absolute;
        top: 3px;
        width: 17px;
    }

    .line-5 {
        height: 14px;
        left: 13px;
        position: absolute;
        top: 2px;
        width: 3px;
    }

    .line-6 {
        height: 3px;
        left: 8px;
        position: absolute;
        top: 8px;
        width: 13px;
    }

    .group-132 {
        align-items: flex-end;
        display: flex;
        height: 20px;
        margin-left: 13px;
        min-width: 40px;
        opacity: 0.5;
        padding: 0.0px 0.0px;
    }

    .overlap-group2 {
        height: 18px;
        position: relative;
        width: 20px;
    }

    .arrow-1 {
        height: 14px;
        left: 5px;
        position: absolute;
        top: 0;
        width: 10px;
        cursor: pointer;
    }

    .ellipse-42 {
        height: 14px;
        left: 0;
        position: absolute;
        top: 4px;
        width: 20px;
        cursor: pointer;
    }

    @import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

    @import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");

    * {
        box-sizing: border-box;
    }

    :root {
        --black: #000000;
        --black-32: #00000091;
        --black-4: #000000cc;
        --gray: #919192;
        --white: #ffffff;
        --font-size-l: 17px;
        --font-size-s: 15px;
        --font-size-xs: 12px;
        --font-size-xxs: 10.4px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-medium-black-17px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-l);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-light-gray-12px {
        color: var(--gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xs);
        font-style: normal;
        font-weight: 300;
        margin-left: 5px;
        margin-top: 2px;
    }

    .fredoka-light-black-15px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-s);
        font-style: normal;
        font-weight: 300;
    }

    .border-0-2px-black {
        border: 0.2px dotted var(--black);
    }

    .border-0-4px-black {
        border: 0.4px solid var(--black);
    }

    .border-0-9px-black-3 {
        border: 0.9px solid var(--black-32);
    }

    .border-0-9px-black-4 {
        border: 0.9px solid var(--black-4);
    }

    .button1 {
        cursor: pointer;
        /*        padding: -5px;
    */ margin: -5px;
    }
</style>

